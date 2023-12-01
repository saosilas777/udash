using Microsoft.AspNetCore.Mvc;

namespace UDash.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
