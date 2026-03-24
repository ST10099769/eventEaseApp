using System.Collections.Generic;

namespace EventEase.Models
{
    public class DashboardViewModel
    {
        public int VenueCount { get; set; }
        public int EventCount { get; set; }
        public int BookingCount { get; set; }

        public List<Event> UpcomingEvents { get; set; }
        public List<Booking> RecentBookings { get; set; }
    }
}