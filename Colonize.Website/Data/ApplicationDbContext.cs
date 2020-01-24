using System;
using System.Collections.Generic;
using System.Text;
using Colonize.Website.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Colonize.Website.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Voyage> Voyage { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            var Ships = new List<Ship>{
                new Ship(1, "MoonShot", "Lorem ipsum", 200, new System.Uri("http://via.placeholder.com/790x800.png?text=Moonshot", UriKind.Absolute)),
                 new Ship(2, "MarsRunner", "Lorem ipsum", 200, new System.Uri("http://via.placeholder.com/790x800.png?text=MarsRunner", UriKind.Absolute)),
            new Ship(3, "StarX", "Lorem ipsum", 200, new System.Uri("http://via.placeholder.com/790x800.png?text=StarX", UriKind.Absolute))



            };

            var Destinations = new List<Destination>{
                new Destination(1, "Moon", "Lorem ipsum", new System.Uri("http://via.placeholder.com/790x800.png?text=Moon", UriKind.Absolute)),
                 new Destination(2, "MarsRunner", "Lorem ipsum", new System.Uri("http://via.placeholder.com/790x800.png?text=Mars", UriKind.Absolute)),
            new Destination(3, "Jupiter", "Lorem ipsum", new System.Uri("http://via.placeholder.com/790x800.png?text=Jupiter", UriKind.Absolute))



            };

            var Voyages = new List<Voyage>{
                new Voyage(1,Destinations[0].Id, Ships[0].Id, new DateTime(2020, 7, 12, 00,00,00), new DateTime(2020, 12, 12, 00,00,00)),
                new Voyage(2,Destinations[1].Id, Ships[1].Id, new DateTime(2020, 8, 8, 00,00,00), new DateTime(2022, 8, 8, 00,00,00))
            };

            Ships.ForEach(x => modelBuilder.Entity<Ship>().HasData(x));
            Destinations.ForEach(x => modelBuilder.Entity<Destination>().HasData(x));
            Voyages.ForEach(x => modelBuilder.Entity<Voyage>().HasData(x));
            //modelBuilder.Entity<Ship>().HasData();
        }
    }
}
