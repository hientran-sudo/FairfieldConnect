namespace FairfieldConnect.Models
{
    public class Thumbnail
    {
        public int ThumbnailID { get; set; }
        public int ClubID { get; set; }
        public int EventID { get; set; }
        public int HousingPostID { get; set; }
        public int SellPostID { get; set; } 
        public Club Club { get; set; }
        public Event Event { get; set; }
        public HousingPost HousingPost { get; set; }
        public SellPost SellPost { get; set; }
        
    }
}
