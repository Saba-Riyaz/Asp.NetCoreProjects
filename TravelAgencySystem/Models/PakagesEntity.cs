using System.ComponentModel.DataAnnotations;

namespace TravelAgencySystem.Models
{
    public class PakagesEntity
    {
        [Key]
        public int PakageId  { get; set; }

        [Required(ErrorMessage = "Required")]
        public string PakageName  { get; set; }


        [Required(ErrorMessage = "Required")]
        public string PakageDescription  { get; set; }

        [Required(ErrorMessage = "Required")]
        public string PakagePrice  { get; set; }

 
    }
}
