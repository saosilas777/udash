using Microsoft.AspNetCore.Mvc;
using UDash.Interfaces;
using UDash.Models;
using UDash.Services;

namespace UDash.Controllers
{
	public class HomeController : Controller
	{
		#region Dependencies
		private readonly ISection _section;
		public HomeController(ISection section)
		{
			_section = section;

		}

		#endregion

		public IActionResult Index()
		{
				return View();			
			
		}
	}
}
