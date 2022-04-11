using System.ComponentModel.DataAnnotations;

namespace FairfieldConnect.Models
{
    public class Event
    {
        public int EventID { get; set; }
        [Required(ErrorMessage = "Please enter a title.")]
        [StringLength(200)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter a description.")]
        public string Desc { get; set; }
        [Required(ErrorMessage = "Please enter a location.")]
        [StringLength(200)]
        public string Location { get; set; }
        public DateTime Hosting { get; set; }

        public int StudentID { get; set; }
        public int ClubID { get; set; }

        public Student Student { get; set; }
        public Club Club { get; set; }
    }
}

