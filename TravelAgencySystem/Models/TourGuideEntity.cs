using System.ComponentModel.DataAnnotations;

namespace TravelAgencySystem.Models
{
    public class TourGuideEntity
    {
        [Key]
        public int GuideId  { get; set; }

        [Required(ErrorMessage = "Required")]
        public string GuideName { get; set; }


        [Required(ErrorMessage = "Required")]
        public string GuideEmail { get; set; }

        [Required(ErrorMessage = "Required")]
        public string GuidePhoneNumber { get; set; }

        [Required(ErrorMessage = "Required")]
        public string LanguagesSpoken  { get; set; }

        [Required(ErrorMessage = "Required")]
        public string GuideBio  { get; set; }


    }
}
    
