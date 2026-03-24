using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Venue
    {
        [Key]
        public int VenueId { get; set; }

        [Required]
        public string VenueName { get; set; }

        [Required]
        public string Location { get; set; }

        [Range(1, int.MaxValue)]
        public int Capacity { get; set; }

        public string? ImageUrl { get; set; }
    }
}