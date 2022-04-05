﻿namespace FairfieldConnect.Models
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
        namespace FairfieldConnect.Models
    {
        public class TutoringPost
        {
            public int TutoringPostID { get; set; }
            public string Title { get; set; }
            public string Desc { get; set; }
            public string Subject { get; set; }
            public double Rate { get; set; }
            public DateTime created { get; set; }
            public DateTime modified { get; set; }

            public int StudentID { get; set; }
            public int CategoryID { get; set; }


            public Student Student { get; set; }
            public Category Category { get; set; }

        }
    }

}
}
