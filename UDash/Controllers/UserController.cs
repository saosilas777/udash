using Microsoft.AspNetCore.Mvc;
using UDash.Interfaces;
using UDash.Models;

namespace UDash.Controllers
{
	public class UserController : Controller
	{
		private readonly IUserRepository _userRepository;

		public UserController(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}
	
		public IActionResult Index()
		{
			return View();
		}

		
		public IActionResult SignUp()
		{
			return View();

		}

		[HttpPost]
		public IActionResult Create(UserModel user)
		{
			if (ModelState.IsValid)
			{
				_userRepository.Create(user);
				return RedirectToAction("Login", "Login");
			}
			return RedirectToAction("SignUp", "User");
		}
	}
}
