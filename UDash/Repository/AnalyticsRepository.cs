using Microsoft.EntityFrameworkCore;
using System.Linq;
using UDash.Data;
using UDash.Interfaces;
using UDash.Models;
using UDash.Models.ViewModels;
using UDash.Services;

namespace UDash.Repository
{
	public class AnalyticsRepository
	{
		private readonly SectionService _sectionService;
		private readonly ICustomerRepository _customerRepository;

		private readonly Context _context;
		public AnalyticsRepository(Context context,
								SectionService section,
								ICustomerRepository customerRepository)
		{
			_context = context;
			_sectionService = section;
			_customerRepository = customerRepository;
		}

		public AnalyticsViewModel BuscarTodos()
		{
			var user = _sectionService.Section();

			List<CustomerModel> customers = _customerRepository.BuscarTodos(user.Id);

			double totalPortfolio = 0;

			for (int i = 0; i < customers.Count(); i++)
			{
				totalPortfolio += customers[i].ValorMensal;
			}
			AnalyticsModel analytics = _context.Analytics.Where(x => x.UserId == user.Id).OrderByDescending(x => x.Registration).FirstOrDefault();
			MeetingsMonths meetings = _context.Meetings.Where(x => x.UserId == user.Id).OrderByDescending(x=>x.Registration).FirstOrDefault();
			NoShowsMonth noShows = _context.NoShows.Where(x => x.UserId == user.Id).OrderByDescending(x => x.Registration).FirstOrDefault();

			AnalyticsViewModel analyticsViewModel = new AnalyticsViewModel
			{
				AverageTicket = totalPortfolio / customers.Count(),
				Churns = analytics.Churns,
				Registration = analytics.Registration,
				TotalCustomer = customers.Count(),
				TotalPortfolio = totalPortfolio,
				UserId = analytics.UserId,
				Meetings = meetings,
				NoShows = noShows,
				
			};

			return analyticsViewModel;
		}

		public void InsertAnalytics(AnalyticsViewModel analytics)
		{
			var user = _sectionService.Section();
			analytics.NoShows.UserId = user.Id;
			analytics.NoShows.Registration = DateTime.Now;
			_context.NoShows.Add(analytics.NoShows);
			analytics.Meetings.UserId = user.Id;
			analytics.Meetings.Registration = DateTime.Now;
			_context.Meetings.Add(analytics.Meetings);


			AnalyticsModel newAnalytics = new AnalyticsModel
			{
				AverageTicket = analytics.AverageTicket,
				UserId = user.Id,
				TotalPortfolio = analytics.TotalPortfolio,
				TotalCustomer = analytics.TotalCustomer,
				Registration = DateTime.Now,
				Churns = analytics.Churns,

			};


			_context.Analytics.Add(newAnalytics);
			_context.SaveChanges();
		}
	}
}
