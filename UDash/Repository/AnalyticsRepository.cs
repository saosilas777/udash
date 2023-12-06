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
		private readonly Context _context;
		public AnalyticsRepository(Context context,
								SectionService section)
		{
			_context = context;
			_sectionService = section;
		}

		public AnalyticsViewModel BuscarTodos()
		{
			var user = _sectionService.Section();

			AnalyticsModel analytics = _context.Analytics.Where(x => x.UserId == user.Id).FirstOrDefault();
			MeetingsMonths meetings = _context.Meetings.Where(x => x.UserId == user.Id).OrderByDescending(x=>x.Registration).FirstOrDefault();
			NoShowsMonth noShows = _context.NoShows.Where(x => x.UserId == user.Id).OrderByDescending(x => x.Registration).FirstOrDefault();

			AnalyticsViewModel analyticsViewModel = new AnalyticsViewModel
			{
				Analytics = analytics,
				Meetings = meetings,
				NoShows = noShows
			};

			return analyticsViewModel;
		}
		public void InsertMeetings(AnalyticsViewModel meetings)
		{
			var user = _sectionService.Section();
			meetings.Meetings.UserId = user.Id;
			meetings.Meetings.Registration = DateTime.Now;
			_context.Meetings.Add(meetings.Meetings);
			_context.SaveChanges();
		}
		public void InsertNoShows(AnalyticsViewModel meetings)
		{
			var user = _sectionService.Section();
			meetings.NoShows.UserId = user.Id;
			meetings.NoShows.Registration = DateTime.Now;
			_context.NoShows.Add(meetings.NoShows);
			_context.SaveChanges();
		}
		public void InsertAnalytics(AnalyticsModel analytics)
		{
			_context.Add(analytics);
			_context.SaveChanges();
		}
	}
}
