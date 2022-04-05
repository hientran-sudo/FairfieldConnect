namespace fairfieldconnect.models
{
    public class Events_model
    {

        public int eventid { get; set; }
        public string eventtitle { get; set; }
        public string eventdesc { get; set; }
        public string eventlocation { get; set; }

        public DateTime eventhosting { get; set; }


        public int Studentid { get; set; }
        public int Clubid { get; set; }



        public Student Student { get; set; }
        public Clubs_Model Clubs_Model { get; set; }


    }
}

