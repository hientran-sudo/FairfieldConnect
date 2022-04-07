namespace FairfieldConnect.Models
    {
        public class MarketPost
        {
            public int MarketPostID { get; set; }
            public string Title { get; set; }
            public string Desc { get; set; }
            public double Price { get; set; }
            public string Location { get; set; }
            public DateTime created { get; set; }
            public DateTime modified { get; set; }

            public int StudentID { get; set; }
            public int CategoryID { get; set; }


            public Student Student { get; set; }
            public Category Category { get; set; }

            public Thumbnail Thumbnail { get; set; }
            public int ThumbnailID { get; set; }

        }
    }



