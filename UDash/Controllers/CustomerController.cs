using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using UDash.Interfaces;
using UDash.Models;
using UDash.Models.ViewModels;
using UDash.Repository;
using UDash.Services;

namespace UDash.Controllers
{
	public class CustomerController : Controller
	{
		private readonly CustomerRepository _customer;
		private readonly ISection _section;
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
			List<CustomerModel> customers = _customer.BuscarTodos(user.Id);
			/*List<Customer> customers = _customer.CreateAt();*/
			string localPage = "#fff";
			return View(customers);
		}

		public IActionResult Editar(Guid id)
		{
			CustomerModel customerDb = _customer.BuscarPorId(id);
			return View(customerDb);
		}

		[HttpPost]
		public IActionResult Edit(CustomerViewModel customer)
		{
			_customer.Editar(customer);
			return RedirectToAction("Index","Customer");
		}

		[HttpPost]
		public IActionResult Delete(CustomerModel customer)
		{
			_customer.Deletar(customer);
			return RedirectToAction("Index", "Customer");
		}


	}
}
