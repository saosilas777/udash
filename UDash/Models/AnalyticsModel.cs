﻿namespace UDash.Models
{
	public class AnalyticsModel
	{
		public Guid Id { get; set; }
		public Guid UserId { get; set; }
		public UserModel User { get; set; }
		public double TotalPortfolio { get; set; }
		public int TotalCustomer { get; set; }
		public double AverageTicket { get; set; }
		public int Churns { get; set; }
		public MeetingsMonths Meeting { get; set; }
		public NoShowsMonth NoShows { get; set; }
	}
}
