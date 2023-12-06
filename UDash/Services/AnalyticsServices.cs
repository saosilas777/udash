using Microsoft.EntityFrameworkCore.Metadata.Internal;
using UDash.Models;
using System.Collections.Generic;
using UDash.Models.ViewModels;

namespace UDash.Services
{
	public class AnalyticsServices
	{
		public AnalyticsModel AnalyticsCreate()
		{
			AnalyticsModel model = new AnalyticsModel();
			model = new AnalyticsModel
			{
				TotalCustomer = 320,
				AverageTicket = 5200,
				TotalPortfolio = 98552.00,
				Churns = 2
			};
			/*model.NoShows = new NoShowsMonth
			{
				Segunda = "1",
				Terca = "2",
				Quarta = "3",
				Quinta = "4",
				Sexta = "5"

			};
			model.Meetings = new MeetingsMonths
			{
				Segunda = "1",
				Terca = "2",
				Quarta = "3",
				Quinta = "4",
				Sexta = "5"

			};*/
			return model;
		}
		/*TODO*/
		//Fazer isso vir do banco e remover todo esse serviço



	}
}
