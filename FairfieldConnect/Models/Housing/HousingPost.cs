namespace FairfieldConnect.Models
{
    public class HousingPost
    {
        public int HousingPostID { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string Address { get; set; }
        public int Rate { get; set; }

        public int StudentID { get; set; }
        public int CategoryID { get; set; }
        public int LandlordID { get; set; }

        public Student Student { get; set; }
        public Category Category { get; set; }
        public Landlord Landlord { get; set; }

    }
}
