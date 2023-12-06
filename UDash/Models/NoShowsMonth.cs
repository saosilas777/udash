namespace UDash.Models
{
	public class NoShowsMonth
	{
		public Guid Id { get; set; }
		public Guid UserId { get; set; }
		public DateTime Registration { get; set; }
		public string Segunda { get; set; } = string.Empty;
		public string Terca { get; set; } = string.Empty;
		public string Quarta { get; set; } = string.Empty;
		public string Quinta { get; set; } = string.Empty;
		public string Sexta { get; set; } = string.Empty;
	}
}
