using System.ComponentModel.DataAnnotations;

namespace TravelAgencySystem.Models
{
    public class CustomerEntity
    {
        [Key]
        public int CustId { get; set; }

        [Required(ErrorMessage = "Required")]
        public string CustName { get; set; }


        [Required(ErrorMessage = "Required")]
        public string CustPhoneNumber  { get; set; }

        [Required(ErrorMessage = "Required")]
        public string CustEmail  { get; set; }

        [Required(ErrorMessage = "Required")]
        public string CustAddress  { get; set; }

    }
}
