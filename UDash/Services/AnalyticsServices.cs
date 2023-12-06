using Microsoft.EntityFrameworkCore.Metadata.Internal;
using UDash.Models;
using System.Collections.Generic;
using UDash.Models.ViewModels;
using UDash.Repository;
using UDash.Interfaces;

namespace UDash.Services
{
	public class AnalyticsServices
	{
		private readonly ICustomerRepository _customerRepository;
		private readonly SectionService _sectionService;

		public AnalyticsServices(ICustomerRepository customerRepository, SectionService sectionService)
		{
			_customerRepository = customerRepository;
			_sectionService = sectionService;
		}

		public AnalyticsModel AnalyticsCreate()
		{
			var user = _sectionService.Section();

			List<CustomerModel> customers = _customerRepository.BuscarTodos(user.Id);

			double totalPortfolio = 0;		

			for (int i = 0; i < customers.Count(); i++)
			{
				totalPortfolio += customers[i].ValorMensal;
			}

			AnalyticsModel model = new AnalyticsModel();
			model = new AnalyticsModel
			{
				TotalCustomer = customers.Count(),
				AverageTicket = totalPortfolio / customers.Count(),
				TotalPortfolio = totalPortfolio,
				Churns = 2,
				Registration = DateTime.Now
				
			};
			return model;
		}
		/*TODO*/
		//Fazer isso vir do banco e remover todo esse serviço



	}
}
