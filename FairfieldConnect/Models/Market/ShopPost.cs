namespace FairfieldConnect.Models.Market
{
    public class ShopPost
    {
        public int ShopPostID { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public double Price { get; set; }
        public DateTime Created { get; set; }

        public int StudentID { get; set; }
        public int CategoryID { get; set; }

        public Student Student { get; set; }
        public Category Category { get; set; }
    }
}
