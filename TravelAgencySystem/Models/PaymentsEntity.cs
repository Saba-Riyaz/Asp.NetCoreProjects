using System.ComponentModel.DataAnnotations;

namespace TravelAgencySystem.Models
{
    public class PaymentsEntity 
    {
        [Key]
        public int PaymentId { get; set; }

        [Required(ErrorMessage = "Required")]
        public string  PaymentDate { get; set; }


        [Required(ErrorMessage = "Required")]
        public string PaymentAmount { get; set; }

        [Required(ErrorMessage = "Required")]
        public string PaymentMethod { get; set; }

        [Required(ErrorMessage = "Required")]
        public string PaymentStatus { get; set; }

        [Required(ErrorMessage = "Required")]
        public int PakageId  { get; set; }

    }
}

