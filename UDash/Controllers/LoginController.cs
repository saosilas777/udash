using Microsoft.AspNetCore.Mvc;
using UDash.Data;
using UDash.Interfaces;
using UDash.Models;
using UDash.Repositories;

namespace UDash.Controllers
{
	public class LoginController : Controller
	{
		private readonly IUserRepository _repository;
		public LoginController(IUserRepository repository)
		{
			_repository = repository;
		}

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
				if (ModelState.IsValid)
				{
					var login = loginModel.Login;
					UserModel user = _repository.BuscarPorLogin(login);
					if(user != null)
					return RedirectToAction("Index", "Home");

				}
								

				return View("Login");
			}
			catch (Exception e)
			{

				throw new Exception(e.Message);
			}
			
		}
	}
}
