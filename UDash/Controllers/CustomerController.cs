using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using UDash.Interfaces;
using UDash.Models;
using UDash.Repository;
using UDash.Services;

namespace UDash.Controllers
{
	public class CustomerController : Controller
	{
		private CustomerRepository _customer;
		private readonly ISection _section;
		private readonly IUserRepository _userRepository;
		public CustomerController(CustomerRepository customer,
									ISection section
									)
		{
			_customer = customer;
			_section = section;
			
		}
		public IActionResult Index()
		{
			string token = _section.GetUserSection();
			UserModel user = TokenService.GetDataInToken(token);
			List<Customer> customers = _customer.BuscarTodos(user.Id);
			/*List<Customer> customers = _customer.CreateAt();*/
			return View(customers);
		}


	}
}
