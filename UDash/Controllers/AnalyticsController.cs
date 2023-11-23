﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UDash.Interfaces;
using UDash.Models;
using UDash.Models.ViewModels;
using UDash.Services;

namespace UDash.Controllers
{
	public class AnalyticsController : Controller
	{
		private readonly ISection _section;
		private readonly AnalyticsServices _analyticsServices;

		public AnalyticsController(ISection section,
								   AnalyticsServices analytics)
		{
			
			_section = section;
			_analyticsServices = analytics;
		}

		public IActionResult Index()
		{
			var section = _section.GetUserSection();

			if (section != null && TokenService.TokenIsValid(section))
			{
				UserModel user = TokenService.GetDataInToken(section);
				var analytics = _analyticsServices.AnalyticsCreate();
				analytics.User = user;

				return View(analytics);
			};
			_section.UserSectionRemove();
			return RedirectToAction("Login", "Login");
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}