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
			
			model.Meeting.Meeting = "20,8,10,15,3";
			model.NoShows.NoShows = "10,5,8,3,4";
			return model;
		}




	}
}
