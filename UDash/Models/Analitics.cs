namespace UDash.Models
{
	public class Analitics
	{
		public double TotalPortfolio { get; set; }
		public int TotalCustomer { get; set; }
		public double AverageTicket { get; set; }
		public int Churns { get; set; }
		public MeetingsMonths? meetings { get; set; }
		public NoShows? NoShows { get; set; }
	}
}
