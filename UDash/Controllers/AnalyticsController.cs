﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UDash.Interfaces;
using UDash.Models;
using UDash.Models.ViewModels;
using UDash.Repository;
using UDash.Services;

namespace UDash.Controllers
{
	public class AnalyticsController : Controller
	{
		private readonly SectionService _sectionService;
		private readonly AnalyticsServices _analyticsServices;
		private readonly AnalyticsRepository _analyticsRepository;

		public AnalyticsController(SectionService sectionService, AnalyticsServices analytics, AnalyticsRepository analyticsRepository)
		{			
			_sectionService = sectionService;			
			_analyticsServices = analytics;
			_analyticsRepository = analyticsRepository;
		}

		public IActionResult Index()
		{
			var analytics = _analyticsRepository.BuscarTodos();
			return View(analytics);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[HttpPost]
		public IActionResult ReceberDatos(AnalyticsViewModel analytics)
		{
			_analyticsRepository.InsertAnalytics(analytics);
			return RedirectToAction("Index", "Analytics");
		}



		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}