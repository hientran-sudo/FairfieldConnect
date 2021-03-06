using System.ComponentModel.DataAnnotations;

namespace FairfieldConnect.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        [Required(ErrorMessage = "Please enter a title.")]
        [StringLength(200)]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Please enter a description.")]
        public string? Desc { get; set; }
        [Required(ErrorMessage = "Please enter an address.")]
        public string? Address { get; set; }
        
        public int StudentID { get; set; }
        public int CategoryID { get; set; }
        public int LandlordID { get; set; }

        public Student? Student { get; set; }
        public Category? Category { get; set; }
        public Landlord? Landlord { get; set; }

    }
}
