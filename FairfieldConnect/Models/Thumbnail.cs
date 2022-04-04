namespace FairfieldConnect.Models
{
    public class Thumbnail
    {
        public int ThumbnailID { get; set; }
        public int Size { get; set; }

        public int HousingPostID { get; set; }
        public HousingPost HousingPost { get; set; }

    }
}
