using System;


namespace Colonize.Website.Data.Entities
{
    public class Voyage
    {

        public int Id { get; private set; }
        public Destination Destination { get; set; }
        public Ship Ship { get; set; }
        public DateTime DepartureAt { get; set; }
        public DateTime ArrvialAt { get; set; }

    }
}
