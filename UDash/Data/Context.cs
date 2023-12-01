using Microsoft.EntityFrameworkCore;
using UDash.Models;

namespace UDash.Data
{
	public class Context : DbContext
	{
		public Context(DbContextOptions<Context> options) : base(options)
		{
		}
		public DbSet<UserModel> Users { get; set; }
		public DbSet<LoginModel> Login { get; set; }
		public DbSet<AnalyticsModel> Analytics { get; set; }
		public DbSet<MeetingsMonths> Meetings { get; set; }
		public DbSet<NoShowsMonth> NoShows { get; set; }
		public DbSet<CustomerModel> Customers { get; set; }



	}
}