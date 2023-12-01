namespace UDash.Models
{
	public class MeetingsMonths
	{
		public Guid Id { get; set; }
		public Guid UserId { get; set; }
		public string Meeting { get; set; } = string.Empty;
	}
}
