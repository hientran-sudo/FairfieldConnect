namespace FairfieldConnect.Models
{
    public class Club
    {
        public int ClubID { get; set; }
        public string Name{ get; set; }
        public string Desc { get; set; }

        public int StudentID { get; set; }
        public int CategoryID { get; set; }

        public Student Student { get; set; }
        public Category Category { get; set; }
        
    }
}
