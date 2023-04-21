using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using planetnineserver.Models;

namespace planetnineserver.Data
{
    public class planetnineservercontext : DbContext
    {
        public planetnineservercontext (DbContextOptions<planetnineservercontext> options)
            : base(options)
        {
        }

        public DbSet<planetnineserver.Models.User> User { get; set; } = default!;

        public DbSet<planetnineserver.Models.Comment> Comment { get; set; } = default!;

        public DbSet<planetnineserver.Models.Favorite> Favorite { get; set; } = default!;

        public DbSet<planetnineserver.Models.Follower> Follower { get; set; } = default!;

        public DbSet<planetnineserver.Models.Message> Message { get; set; } = default!;

        public DbSet<planetnineserver.Models.MessageComment> MessageComment { get; set; } = default!;

        public DbSet<planetnineserver.Models.Moon> Moon { get; set; } = default!;

        public DbSet<planetnineserver.Models.Planet> Planet { get; set; } = default!;

        public DbSet<planetnineserver.Models.Post> Post { get; set; } = default!;

        public DbSet<planetnineserver.Models.Chat> Chats { get; set; } = default!;

        public DbSet<planetnineserver.Models.ChatComment> ChatComments { get; set; } = default!;

        public DbSet<planetnineserver.Models.ArtificialIntelligence> ArtificialIntelligences { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Planet>().HasData(
                new Planet { PlanetId = 2, PlanetName = "Mercury", PlanetMass = "3.30114", Perihelion = "46001200", Aphelion = "69816900", Gravity = "3.7", Temperature = "5.4291", ImageLink = "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBc0VRIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--b43e79a5b43d2063c4866ccff66bede5faff17b8/mercury_th.jpg", UserId = 1 },
                new Planet { PlanetId = 3, PlanetName = "Venus", PlanetMass = "4.86747", Perihelion = "107477000", Aphelion = "108939000", Gravity = "8.87", Temperature = "5.243", ImageLink = "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBajl5IiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--1771be6bd46710c30aa93cd6c3ababe23ad52681/480x320_venus.png?disposition=inline", UserId = 1 },
                new Planet { PlanetId = 4, PlanetName = "Earth", PlanetMass = "5.97237", Perihelion = "147095000", Aphelion = "152100000", Gravity = "9.8", Temperature = "5.5136", ImageLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/60/Earth_from_Space.jpg/2048px-Earth_from_Space.jpg", UserId = 1 },
                new Planet { PlanetId = 5, PlanetName = "Mars", PlanetMass = "3.71", Perihelion = "206700000", Aphelion = "249200000", Gravity = "3.7", Temperature = "3.9341", ImageLink = "https://solarsystem.nasa.gov/system/stellar_items/image_files/6_mars.jpg", UserId = 1 },
                new Planet { PlanetId = 6, PlanetName = "Jupiter", PlanetMass = "1.89819", Perihelion = "740379835", Aphelion = "816620000", Gravity = "24.79", Temperature = "1.3262", ImageLink = "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBdGxyIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--229ba26c079b7122001319d5dcffec49c8d4e0cb/STSCI-H-p1936a-f-640.jpg?disposition=attachment", UserId = 1 },
                new Planet { PlanetId = 7, PlanetName = "Saturn", PlanetMass = "5.68336", Perihelion = "1349823615", Aphelion = "1503509229", Gravity = "10.44", Temperature = "0.6871", ImageLink = "https://solarsystem.nasa.gov/system/stellar_items/image_files/38_saturn_1600x900.jpg", UserId = 1 },
                new Planet { PlanetId = 8, PlanetName = "Uranus", PlanetMass = "8.68127", Perihelion = "2734998229", Aphelion = "3006318143", Gravity = "8.87", Temperature = "1.27", ImageLink = "https://images.english.elpais.com/resizer/BH_KvY_lAzwSrpp8v7D55nGax8A=/1960x1470/filters:focal(2464x2210:2474x2220)/cloudfront-eu-central-1.images.arcpublishing.com/prisa/WQ773ELGFRDOHJ46MOLRXKJ7AY.jpg", UserId = 1 },
                new Planet { PlanetId = 9, PlanetName = "Neptune", PlanetMass = "1.02413", Perihelion = "4459753056", Aphelion = "4537039826", Gravity = "11.15", Temperature = "1.638", ImageLink = "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBbkp5IiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--cb7cb2868fd8b4892788893961c20975baffeb52/neptune_480x320.jpg?disposition=inline", UserId = 1 }
            );
        }
    }
}
