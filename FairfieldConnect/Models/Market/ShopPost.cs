using System.ComponentModel.DataAnnotations;

namespace FairfieldConnect.Models.Market
{
    public class ShopPost
    {
        public int ShopPostID { get; set; }
        [Required(ErrorMessage = "Please enter a title.")]
        [StringLength(200)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter a description.")]
        public string Desc { get; set; }
        [Range(0.0, 1000000.0, ErrorMessage = "Price must be more than 0.")]
        public double Price { get; set; }
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
