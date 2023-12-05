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
		private readonly ICustomerRepository _customer;
		private readonly SectionService _sectionService;
		public CustomerController(ICustomerRepository customer,
									SectionService sectionService
									)
		{
			_customer = customer;
			_sectionService = sectionService;
			
		}
		public IActionResult Index()
		{
			var user = _sectionService.Section();
			List<CustomerModel> customers = _customer.BuscarTodos(user.Id);
			/*List<Customer> customers = _customer.CreateAt();*/
			return View(customers);
		}

		public IActionResult Editar(Guid id)
		{
			CustomerModel customerDb = _customer.BuscarPorId(id);
			return View(customerDb);
		}
		
		public IActionResult TodasAsContas(Guid id)
		{
			List<CustomerModel> customers = _customer.BuscarContasIdStarlord(id);
			return View(customers);
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
