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
		public IActionResult SignUp()
		{
			return View();

		}

		[HttpPost]
		public IActionResult Create(LoginModel loginModel)
		{
			if (ModelState.IsValid)
			{
				_repository.Create(loginModel);
				return RedirectToAction("Login", "Login");
			}
			return View("Login");
			/*}
			return RedirectToAction("SignUp", "User");*/
		}

		[HttpPost]
		public IActionResult Entrar(LoginModel loginModel)
		{
			
			try
			{
					var login = loginModel.Login;
					UserModel user = _repository.BuscarPorLogin(loginModel);
					if(user != null)
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
