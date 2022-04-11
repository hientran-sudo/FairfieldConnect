using System.ComponentModel.DataAnnotations;

namespace FairfieldConnect.Models
{
    public class TutoringPost
    {
        public int TutoringPostID { get; set; }
        [Required(ErrorMessage = "Please enter a title.")]
        [StringLength(200)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter a description.")]
        public string Desc { get; set; }
        [Required(ErrorMessage = "Please enter a subject.")]
        [StringLength(200)]
        public string Subject { get; set; }
        [Range(0.0, 1000000.0, ErrorMessage = "Rate must be more than 0.")]
        public double Rate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Created")]
        public DateTime Created { get; set; }

        public int StudentID { get; set; }
        public int CategoryID { get; set; }

        public Student Student { get; set; }
        public Category Category { get; set; }

    }
}



