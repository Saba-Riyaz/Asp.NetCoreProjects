using System.ComponentModel.DataAnnotations;

namespace TravelAgencySystem.Models
{
    public class HotelBookingEntity
    {

        [Key]
        public int HotelId  { get; set; }

        [Required(ErrorMessage = "Required")]
        public string HotelName { get; set; }


        [Required(ErrorMessage = "Required")]
        public string CheckInDate { get; set; }

        [Required(ErrorMessage = "Required")]
        public string CheckOutDate { get; set; }

        [Required(ErrorMessage = "Required")]
        public string RoomType { get; set; }

        [Required(ErrorMessage = "Required")]
        public string RoomRate { get; set; }

        [Required(ErrorMessage = "Required")]
        public int CustId { get; set; }

    }
}
  
