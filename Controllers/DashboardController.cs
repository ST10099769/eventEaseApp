using EventEase.Data;
using EventEase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EventEase.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var model = new DashboardViewModel
            {
                VenueCount = _context.Venues.Count(),
                EventCount = _context.Events.Count(),
                BookingCount = _context.Bookings.Count(),

                UpcomingEvents = _context.Events
                    .Where(e => e.EventDate >= DateTime.Now)
                    .OrderBy(e => e.EventDate)
                    .Take(5)
                    .ToList(),

                RecentBookings = _context.Bookings
                    .OrderByDescending(b => b.BookingDate)
                    .Take(5)
                    .ToList()
            };

            return View(model);
        }


    }
}



