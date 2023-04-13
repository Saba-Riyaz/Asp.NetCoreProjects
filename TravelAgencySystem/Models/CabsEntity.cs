using System.ComponentModel.DataAnnotations;

namespace TravelAgencySystem.Models
{
    public class CabsEntity
    {
        [Key]
        public int CabId { get; set; }

        [Required(ErrorMessage = "Required")]
        public string CabName { get; set; }


        [Required(ErrorMessage = "Required")]
        public string CabType  { get; set; }

        [Required(ErrorMessage = "Required")]
        public string CabDescription { get; set; }

        [Required(ErrorMessage = "Required")]
        public string CabNumber { get; set; }


    }
}

