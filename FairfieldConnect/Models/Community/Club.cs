using System.ComponentModel.DataAnnotations;

namespace FairfieldConnect.Models
{
    public class Club
    {
        public int ClubID { get; set; }
        [Required(ErrorMessage = "Please enter a name.")]
        [StringLength(200)]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter a description.")]
        public string? Desc { get; set; }

        public int StudentID { get; set; }
        public int CategoryID { get; set; }

        public Student? Student { get; set; }
        public Category? Category { get; set; }
        
    }
}
