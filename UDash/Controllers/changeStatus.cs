using Microsoft.AspNetCore.Mvc;
using UDash.Models;

namespace UDash.Controllers
{
	public class changeStatus : Controller
	{
		[HttpPost]
		public IActionResult ChangeStatus([FromForm] CustomerModel status)
		{
			return View();
		}
	}
}
