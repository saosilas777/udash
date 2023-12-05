using Microsoft.AspNetCore.Mvc;
using UDash.Interfaces;
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
			try
			{
				var user = _sectionService.Section();
				return View(user);
			}
			catch (Exception e)
			{

				throw new Exception(e.Message);
			}
			
		}
	}
}
