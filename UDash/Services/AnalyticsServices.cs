using Microsoft.EntityFrameworkCore.Metadata.Internal;
using UDash.Models;
using System.Collections.Generic;

namespace UDash.Services
{
	public class AnalyticsServices
	{
		public AnalyticsModel AnalyticsCreate()
		{
			AnalyticsModel model = new AnalyticsModel();
			model.TotalPortfolio = 98150.50;
			model.TotalCustomer = 151;
			model.Churns = 5;
			model.AverageTicket = 2500.55;

			MeetingsMonths meets = new MeetingsMonths
			{
				Id = Guid.NewGuid(),
				UserId = Guid.NewGuid(),
				Meeting = "20,8,10,15,3"

			};
			NoShowsMonth noShows = new NoShowsMonth
			{
				Id = Guid.NewGuid(),
				UserId = Guid.NewGuid(),
				NoShows = "10,5,8,3,4"

			};

			model.Meeting = meets;
			model.NoShows = noShows;
			return model;
		}
		/*TODO*/
		//Fazer isso vir do banco e remover todo esse serviço



	}
}
