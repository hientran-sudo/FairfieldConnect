using System.ComponentModel.DataAnnotations;

namespace FairfieldConnect.Models
{
    public class ListPost
    {
        public int ListPostID { get; set; }
        [Required(ErrorMessage = "Please enter a title.")]
        [StringLength(200)]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Please enter a description.")]
        public string? Desc { get; set; }
        [Required(ErrorMessage = "Please enter an address.")]
        public string? Address { get; set; }
        [Range(0.0, 1000000.0, ErrorMessage = "Rate must be more than 0.")]
        public int Rate { get; set; }

        public int StudentID { get; set; }
        public int CategoryID { get; set; }
        public int LandlordID { get; set; }

        public Student? Student { get; set; }
        public Category? Category { get; set; }
        public Landlord? Landlord { get; set; }

    }
}
