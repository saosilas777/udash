using Microsoft.AspNetCore.Mvc;
using UDash.Interfaces;
using UDash.Models;
using UDash.Services;

namespace UDash.Controllers
{
	public class SendFileController : Controller
	{
		private readonly SendFileService _sendFileServices;
		private readonly ISection _section;
		private readonly ICustomerRepository _customerRepository;

		public SendFileController(ISection section, SendFileService sendFileServices, ICustomerRepository customerRepository)
		{
			
			_section = section;
			_sendFileServices = sendFileServices;
			_customerRepository = customerRepository;
		}

		[HttpPost]
		public IActionResult SendFile(IFormFile uploadFile)
		{
			List<CustomerModel> contatos = _sendFileServices.ReadXls(uploadFile);
			List<CustomerModel> newList = VerifyDuplicate(contatos);
			_customerRepository.AdicionarTodos(newList);
			return RedirectToAction("Index", "Contato");
		}

		public IActionResult EnviarArquivo()
		{
			return RedirectToAction("Index", "Home");
		}

		public List<CustomerModel> VerifyDuplicate(List<CustomerModel> customer)
		{
			var token = _section.GetUserSection();
			var user = TokenService.GetDataInToken(token);
			List<CustomerModel> customerDb = _customerRepository.BuscarTodos(user.Id);

			for (int i = 0; i < customerDb.Count; i++)
			{
				for (int j = 0; j < customer.Count; j++)
				{
					if (customer[j].IdSense == customerDb[i].IdSense)
					{
						customer.Remove(customer[j]);
					}
				}

			}
			return customer;
		}
	}
}
