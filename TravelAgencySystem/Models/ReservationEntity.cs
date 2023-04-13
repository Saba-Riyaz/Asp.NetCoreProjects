using System.ComponentModel.DataAnnotations;

namespace TravelAgencySystem.Models
{
    public class ReservationEntity
    {
        [Key]
        public int ResId { get; set; }

        [Required(ErrorMessage = "Required")]
        public string ResDate { get; set; }


        [Required(ErrorMessage = "Required")]
        public int PakageId { get; set; }

        [Required(ErrorMessage = "Required")]
        public int HotelId { get; set; }

        [Required(ErrorMessage = "Required")]
        public int FlightId { get; set; }

        [Required(ErrorMessage = "Required")]
        public int GuideId { get; set; }

        [Required(ErrorMessage = "Required")]
        public int CustId { get; set; }

        [Required(ErrorMessage = "Required")]
        public int CabId { get; set; }

        [Required(ErrorMessage = "Required")]
        public int PaymentId  { get; set; }
    }
}
