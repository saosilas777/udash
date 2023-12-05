using Microsoft.AspNetCore.Mvc;
using UDash.Interfaces;
using UDash.Models;
using UDash.Services;

namespace UDash.Controllers
{
	public class UserController : Controller
	{
		private readonly IUserRepository _userRepository;
		private readonly ISection _section;

		public UserController(IUserRepository userRepository, ISection section)
		{
			_userRepository = userRepository;
			_section = section;
		}
	
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult ChangePassword()
		{
			var user = TokenService.GetDataInToken( _section.GetUserSection());

			return View(user);
		}
		
		

		
	}
}
