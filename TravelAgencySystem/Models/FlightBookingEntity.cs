using System.ComponentModel.DataAnnotations;

namespace TravelAgencySystem.Models
{
    public class FlightBookingEntity
    {
        [Key]
        public int FlightId  { get; set; }

        [Required(ErrorMessage = "Required")]
        public string FlightNumber  { get; set; }


        [Required(ErrorMessage = "Required")]
        public string DepartureCity { get; set; }

        [Required(ErrorMessage = "Required")]
        public string ArivalCity { get; set; }

        [Required(ErrorMessage = "Required")]
        public string DepartureDate { get; set; }

        [Required(ErrorMessage = "Required")]
        public string ArivalDate { get; set; }


        [Required(ErrorMessage = "Required")]
        public int CustId { get; set; }


    }
}

    