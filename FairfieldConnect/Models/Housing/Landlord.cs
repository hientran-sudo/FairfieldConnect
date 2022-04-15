using System.ComponentModel.DataAnnotations;

namespace FairfieldConnect.Models
{
    public class Landlord
    {
        public int LandlordID { get; set; }
        [Required(ErrorMessage = "Please enter a name.")]
        [StringLength(200)]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter a phone number.")]
        [StringLength(200)]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Please enter an email.")]
        [StringLength(200)]
        public string? Email { get; set; }

    }
}
