namespace FairfieldConnect.Models
{
    public class Socialize_Model
    {
        public int SocializeEventId { get; set; }
        public string SocializeEventName { get; set; }
        public string SocializeEventDesc { get; set; }
        public DateTime SocializeEventHosting { get; set; }


        public int StudentID { get; set; }
        public int EventID { get; set; }


       
            public Student Student { get; set; }
            public Category Category { get; set; }
        public Thumbnail Thumbnail { get; set; }
        public int ThumbnailID { get; set; }

    }
    }



