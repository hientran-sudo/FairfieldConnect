namespace FairfieldConnect.Models
{
    public class Event
    {
        public int EventID { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string Location { get; set; }
        public DateTime Hosting { get; set; }

        public int StudentID { get; set; }
        public int ClubID { get; set; }

        public Student Student { get; set; }
        public Club Club { get; set; }
    }
}

