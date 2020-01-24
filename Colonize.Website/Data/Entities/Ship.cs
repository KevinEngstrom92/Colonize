using System;

namespace Colonize.Website.Data.Entities
{
    public class Ship
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ushort PassengerCapacity { get; set; }
        public Uri ImageUrl { get; set; }

    }
}