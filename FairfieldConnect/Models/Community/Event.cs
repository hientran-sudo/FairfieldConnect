using System.ComponentModel.DataAnnotations;

namespace FairfieldConnect.Models
{
    public class Event
    {
        public int EventID { get; set; }
        [Required(ErrorMessage = "Please enter a title.")]
        [StringLength(200)]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Please enter a description.")]
        public string? Desc { get; set; }
        [Required(ErrorMessage = "Please enter a location.")]
        [StringLength(200)]
        public string? Location { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hosting")]
        public DateTime Hosting { get; set; }

        public int ClubID { get; set; }
        public Club? Club { get; set; }
    }
}

