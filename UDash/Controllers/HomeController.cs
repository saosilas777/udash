using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UDash.Interfaces;
using UDash.Models;
using UDash.Models.ViewModels;
using UDash.Services;

namespace UDash.Controllers
{
	public class HomeController : Controller
	{
		private readonly ISection _section;

		public HomeController(ISection section)
		{
			
			_section = section;
		}

		public IActionResult Index()
		{
			var section = _section.GetUserSection();

			if (section != null && TokenService.TokenIsValid(section))
			{
				UserModel user = TokenService.GetDataInToken(section);
				return View(user);
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