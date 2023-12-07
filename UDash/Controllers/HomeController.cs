using Microsoft.AspNetCore.Mvc;
using UDash.Interfaces;
using UDash.Models;
using UDash.Services;

namespace UDash.Controllers
{
	public class HomeController : Controller
	{
		private readonly SectionService _sectionService;
		public HomeController(SectionService sectionService)
		{
			_sectionService = sectionService;

		}
		public IActionResult Index()
		{
				return View();			
			
		}
	}
}
