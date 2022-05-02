using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace FairfieldConnect.Models
{
    public class Thumbnail
    {
        public int ThumbnailID { get; set; } 
        [Column(TypeName ="nvarchar(50)")]
        public string? Title { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? ThumbnailName { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile? ThumbnailFile { get; set; }

        public Review? Review { get; set; }
        public int? ReviewID { get; set; }

    }
}
