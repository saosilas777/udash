using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UDash.Interfaces;
using UDash.Models;
using UDash.Models.ViewModels;
using UDash.Services;

namespace UDash.Controllers
{
	public class AnalyticsController : Controller
	{
		private readonly SectionService _sectionService;
		private readonly AnalyticsServices _analyticsServices;

		public AnalyticsController(SectionService sectionService, AnalyticsServices analytics)
		{			
			_sectionService = sectionService;			
			_analyticsServices = analytics;
		}

		public IActionResult Index()
		{

			var user = _sectionService.Section();
			if (user != null)
			{
				var analytics = _analyticsServices.AnalyticsCreate();
				analytics.User = user;
				return View(analytics);
			};
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