using Microsoft.AspNetCore.Mvc;
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
		private readonly ISection _section;
		private readonly AnalyticsRepository _analyticsRepository;

		public AnalyticsController(ISection section, AnalyticsRepository analyticsRepository)
		{
			_section = section;			
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
	}
}