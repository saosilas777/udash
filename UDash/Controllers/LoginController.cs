using Microsoft.AspNetCore.Mvc;
using UDash.Models;

namespace UDash.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Login()
		{
			return View();
		}
		
		public IActionResult Logout()
		{
			return RedirectToAction("Login");
		}

		[HttpPost]
		public IActionResult Entrar(LoginModel loginModel)
		{
			try
			{
				if(loginModel.Password == "nai1606" || loginModel.Password == "silas2201")
					return RedirectToAction("Index", "Home");				

				return View("Login");
			}
			catch (Exception e)
			{

				throw new Exception(e.Message);
			}
			
		}
	}
}
