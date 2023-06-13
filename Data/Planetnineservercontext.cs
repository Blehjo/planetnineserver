using Microsoft.EntityFrameworkCore;
using Planetnineserver.Models;

namespace Planetnineserver.Data
{
    public class Planetnineservercontext : DbContext
    {
        public Planetnineservercontext (DbContextOptions<Planetnineservercontext> options)
            : base(options)
        {
            //Database.EnsureCreated();
            //Database.GetMigrations();
        }

        public DbSet<Planetnineserver.Models.User> User { get; set; } = default!;

        public DbSet<Planetnineserver.Models.Comment> Comment { get; set; } = default!;

        public DbSet<Planetnineserver.Models.Favorite> Favorite { get; set; } = default!;

        public DbSet<Planetnineserver.Models.Follower> Follower { get; set; } = default!;

        public DbSet<Planetnineserver.Models.Message> Message { get; set; } = default!;

        public DbSet<Planetnineserver.Models.MessageComment> MessageComment { get; set; } = default!;

        public DbSet<Planetnineserver.Models.Moon> Moon { get; set; } = default!;

        public DbSet<Planetnineserver.Models.Planet> Planet { get; set; } = default!;

        public DbSet<Planetnineserver.Models.Post> Post { get; set; } = default!;

        public DbSet<Planetnineserver.Models.Chat> Chats { get; set; } = default!;

        public DbSet<Planetnineserver.Models.ChatComment> ChatComments { get; set; } = default!;

        public DbSet<Planetnineserver.Models.ArtificialIntelligence> ArtificialIntelligences { get; set; } = default!;

        public DbSet<Planetnineserver.Models.MoonComment> MoonComment { get; set; } = default!;

        public DbSet<Planetnineserver.Models.PlanetComment> PlanetComment { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Username = "spacemarauder", FirstName = "malorian", LastName = "major", Password = "Password1", About = "cyberpunk", EmailAddress = "spacemarauder@email.com" }
            );
            modelBuilder.Entity<Planet>().HasData(
                new Planet { PlanetId = 2, PlanetName = "Mercury", PlanetMass = "3.30114", Perihelion = "46001200", Aphelion = "69816900", Gravity = "3.7", Temperature = "5.4291", Brief = "From the surface of Mercury, the Sun would appear more than three times as large as it does when viewed from Earth, and the sunlight would be as much as 11 times brighter.", Description = "The smallest planet in our solar system and nearest to the Sun, Mercury is only slightly larger than Earth's Moon. From the surface of Mercury, the Sun would appear more than three times as large as it does when viewed from Earth, and the sunlight would be as much as seven times brighter. Despite its proximity to the Sun, Mercury is not the hottest planet in our solar system – that title belongs to nearby Venus, thanks to its dense atmosphere. Because of Mercury's elliptical – egg-shaped – orbit, and sluggish rotation, the Sun appears to rise briefly, set, and rise again from some parts of the planet's surface. The same thing happens in reverse at sunset.", ModelLink = "https://solarsystem.nasa.gov/gltf_embed/2369", ImageLink = "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBc0VRIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--b43e79a5b43d2063c4866ccff66bede5faff17b8/mercury_th.jpg", UserId = 1 },
                new Planet { PlanetId = 3, PlanetName = "Venus", PlanetMass = "4.86747", Perihelion = "107477000", Aphelion = "108939000", Gravity = "8.87", Temperature = "5.243", Brief = "Similar in structure and size to Earth, Venus's thick atmosphere traps heat in a runaway greenhouse effect, making it the hottest planet in our solar system.", Description = "Venus is the second planet from the Sun and is Earth’s closest planetary neighbor. It’s one of the four inner, terrestrial (or rocky) planets, and it’s often called Earth’s twin because it’s similar in size and density. These are not identical twins, however – there are radical differences between the two worlds. Venus has a thick, toxic atmosphere filled with carbon dioxide and it’s perpetually shrouded in thick, yellowish clouds of sulfuric acid that trap heat, causing a runaway greenhouse effect. It’s the hottest planet in our solar system, even though Mercury is closer to the Sun. Surface temperatures on Venus are about 900 degrees Fahrenheit (475 degrees Celsius) – hot enough to melt lead. The surface is a rusty color and it’s peppered with intensely crunched mountains and thousands of large volcanoes. Scientists think it’s possible some volcanoes are still active. Another big difference from Earth – Venus rotates on its axis backward, compared to most of the other planets in the solar system. This means that, on Venus, the Sun rises in the west and sets in the east, opposite to what we experience on Earth. (It’s not the only planet in our solar system with such an oddball rotation – Uranus spins on its side.)", ModelLink = "https://solarsystem.nasa.gov/gltf_embed/2343", ImageLink = "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBajl5IiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--1771be6bd46710c30aa93cd6c3ababe23ad52681/480x320_venus.png?disposition=inline", UserId = 1 },
                new Planet { PlanetId = 4, PlanetName = "Earth", PlanetMass = "5.97237", Perihelion = "147095000", Aphelion = "152100000", Gravity = "9.8", Temperature = "5.5136", Brief = "Earth—our home planet—is the only place we know of so far that’s inhabited by living things. It's also the only planet in our solar system with liquid water on the surface.", Description = "Our home planet is the third planet from the Sun, and the only place we know of so far that’s inhabited by living things. While Earth is only the fifth largest planet in the solar system, it is the only world in our solar system with liquid water on the surface. Just slightly larger than nearby Venus, Earth is the biggest of the four planets closest to the Sun, all of which are made of rock and metal. Earth is the only planet in the Solar System whose English name does not come from Greek or Roman mythology. The name was taken from Old English and Germanic. It simply means the ground. There are, of course, many names for our planet in the thousands of languages spoken by the people of the third planet from the Sun.", ModelLink = "https://solarsystem.nasa.gov/gltf_embed/2393", ImageLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/60/Earth_from_Space.jpg/2048px-Earth_from_Space.jpg", UserId = 1 },
                new Planet { PlanetId = 5, PlanetName = "Mars", PlanetMass = "3.71", Perihelion = "206700000", Aphelion = "249200000", Gravity = "3.7", Temperature = "3.9341", Brief = "Mars is a dusty, cold, desert world with a very thin atmosphere. There is strong evidence Mars was – billions of years ago – wetter and warmer, with a thicker atmosphere.", Description = "​Mars is the fourth planet from the Sun – a dusty, cold, desert world with a very thin atmosphere. Mars is also a dynamic planet with seasons, polar ice caps, canyons, extinct volcanoes, and evidence that it was even more active in the past. Mars is one of the most explored bodies in our solar system, and it's the only planet where we've sent rovers to roam the alien landscape. NASA currently has two rovers (Curiosity and Perseverance), one lander (InSight), and one helicopter (Ingenuity) exploring the surface of Mars.", ModelLink = "https://solarsystem.nasa.gov/gltf_embed/2372", ImageLink = "https://solarsystem.nasa.gov/system/stellar_items/image_files/6_mars.jpg", UserId = 1 },
                new Planet { PlanetId = 6, PlanetName = "Jupiter", PlanetMass = "1.89819", Perihelion = "740379835", Aphelion = "816620000", Gravity = "24.79", Temperature = "1.3262", Brief = "Jupiter is more than twice as massive than the other planets of our solar system combined. The giant planet's Great Red Spot is a centuries-old storm bigger than Earth.", Description = "Jupiter has a long history of surprising scientists – all the way back to 1610 when Galileo Galilei found the first moons beyond Earth. That discovery changed the way we see the universe. Jupiter's familiar stripes and swirls are actually cold, windy clouds of ammonia and water, floating in an atmosphere of hydrogen and helium. Jupiter’s iconic Great Red Spot is a giant storm bigger than Earth that has raged for hundreds of years", ModelLink = "https://solarsystem.nasa.gov/gltf_embed/2375", ImageLink = "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBdGxyIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--229ba26c079b7122001319d5dcffec49c8d4e0cb/STSCI-H-p1936a-f-640.jpg?disposition=attachment", UserId = 1 },
                new Planet { PlanetId = 7, PlanetName = "Saturn", PlanetMass = "5.68336", Perihelion = "1349823615", Aphelion = "1503509229", Gravity = "10.44", Temperature = "0.6871", Brief = "Adorned with a dazzling, complex system of icy rings, Saturn is unique in our solar system. The other giant planets have rings, but none are as spectacular as Saturn's.", Description = "Saturn is the sixth planet from the Sun and the second-largest planet in our solar system. Adorned with thousands of beautiful ringlets, Saturn is unique among the planets. It is not the only planet to have rings – made of chunks of ice and rock – but none are as spectacular or as complicated as Saturn's. Like fellow gas giant Jupiter, Saturn is a massive ball made mostly of hydrogen and helium.", ModelLink = "https://solarsystem.nasa.gov/gltf_embed/2355", ImageLink = "https://solarsystem.nasa.gov/system/stellar_items/image_files/38_saturn_1600x900.jpg", UserId = 1 },
                new Planet { PlanetId = 8, PlanetName = "Uranus", PlanetMass = "8.68127", Perihelion = "2734998229", Aphelion = "3006318143", Gravity = "8.87", Temperature = "1.27", Brief = "Uranus—seventh planet from the Sun—rotates at a nearly 90-degree angle from the plane of its orbit. This unique tilt makes Uranus appear to spin on its side.", Description = "Uranus is the seventh planet from the Sun, and has the third-largest diameter in our solar system. It was the first planet found with the aid of a telescope, Uranus was discovered in 1781 by astronomer William Herschel, although he originally thought it was either a comet or a star. It was two years later that the object was universally accepted as a new planet, in part because of observations by astronomer Johann Elert Bode. Herschel tried unsuccessfully to name his discovery Georgium Sidus after King George III. Instead, the scientific community accepted Bode's suggestion to name it Uranus, the Greek god of the sky, as suggested by Bode.​", ModelLink = "https://solarsystem.nasa.gov/gltf_embed/2344&", ImageLink = "https://images.english.elpais.com/resizer/BH_KvY_lAzwSrpp8v7D55nGax8A=/1960x1470/filters:focal(2464x2210:2474x2220)/cloudfront-eu-central-1.images.arcpublishing.com/prisa/WQ773ELGFRDOHJ46MOLRXKJ7AY.jpg", UserId = 1 },
                new Planet { PlanetId = 9, PlanetName = "Neptune", PlanetMass = "1.02413", Perihelion = "4459753056", Aphelion = "4537039826", Gravity = "11.15", Temperature = "1.638", Brief = "Neptune—the eighth and most distant major planet orbiting our Sun—is dark, cold and whipped by supersonic winds. It was the first planet located through mathematical calculations.", Description = "Dark, cold, and whipped by supersonic winds, ice giant Neptune is the eighth and most distant planet in our solar system. More than 30 times as far from the Sun as Earth, Neptune is the only planet in our solar system not visible to the naked eye and the first predicted by mathematics before its discovery. In 2011 Neptune completed its first 165-year orbit since its discovery in 1846. NASA's Voyager 2 is the only spacecraft to have visited Neptune up close. It flew past in 1989 on its way out of the solar system.", ModelLink = "https://solarsystem.nasa.gov/gltf_embed/2364", ImageLink = "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBbkp5IiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--cb7cb2868fd8b4892788893961c20975baffeb52/neptune_480x320.jpg?disposition=inline", UserId = 1 }
            );
            modelBuilder.Entity<Moon>().HasData(
                new Moon { MoonId = 1, MoonName = "Moon", MoonMass = "7.346", Perihelion = "363300", Aphelion = "405500", Temperature = "3.344", Gravity = "1.62", PlanetId = 4, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 2, MoonName = "Phobos", MoonMass = "1.06", Perihelion = "9234", Aphelion = "9518", Temperature = "1.9", Gravity = "0.0057", PlanetId = 5, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 3, MoonName = "Deimos", MoonMass = "1.4762", Perihelion = "23456", Aphelion = "23471", Temperature = "1.75", Gravity = "0.003", PlanetId = 5, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 4, MoonName = "Io", MoonMass = "8.932", Perihelion = "420071", Aphelion = "423529", Temperature = "3.53", Gravity = "1.79", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 5, MoonName = "Europa", MoonMass = "4.8", Perihelion = "0", Aphelion = "0", Temperature = "3.01", Gravity = "1.31", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 6, MoonName = "Ganymede", MoonMass = "1.4819", Perihelion = "0", Aphelion = "0", Temperature = "1.94", Gravity = "1.428", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 7, MoonName = "Callisto", MoonMass = "1.0759", Perihelion = "0", Aphelion = "0", Temperature = "1.83", Gravity = "1.235", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 8, MoonName = "Amalthea", MoonMass = "7.5", Perihelion = "181150", Aphelion = "182840", Temperature = "3.1", Gravity = "0.02", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 9, MoonName = "Himalia", MoonMass = "9.5", Perihelion = "9782900", Aphelion = "13082000", Temperature = "1", Gravity = "0.062", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 10, MoonName = "Elara", MoonMass = "8", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.031", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 11, MoonName = "Pasiphae", MoonMass = "3", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.022", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 12, MoonName = "Sinope", MoonMass = "8", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.014", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 13, MoonName = "Lysithea", MoonMass = "8", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.013", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 14, MoonName = "Carme", MoonMass = "1", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.017", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 15, MoonName = "Ananke", MoonMass = "4", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.01", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 16, MoonName = "Leda", MoonMass = "6", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.0073", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 17, MoonName = "Thebe", MoonMass = "8", Perihelion = "218000", Aphelion = "226000", Temperature = "1", Gravity = "0.02", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 18, MoonName = "Adrastea", MoonMass = "2", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.002", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 19, MoonName = "Metis", MoonMass = "1", Perihelion = "127974", Aphelion = "128026", Temperature = "1", Gravity = "0.005", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 20, MoonName = "Callirrhoe", MoonMass = "8.7", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.0031", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 21, MoonName = "Themisto", MoonMass = "6.9", Perihelion = "5909000", Aphelion = "8874300", Temperature = "1", Gravity = "0.0029", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 22, MoonName = "Megaclite", MoonMass = "2.1", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 23, MoonName = "Taygete", MoonMass = "1.6", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 24, MoonName = "Chaldene", MoonMass = "7.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 25, MoonName = "Harpalyke", MoonMass = "1.2", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 26, MoonName = "Kalyke", MoonMass = "1.9", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 27, MoonName = "Iocaste", MoonMass = "1.9", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 28, MoonName = "Erinome", MoonMass = "4.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 29, MoonName = "Isonoe", MoonMass = "7.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 30, MoonName = "Praxidike", MoonMass = "4.3", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 31, MoonName = "Autonoe", MoonMass = "9", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.0015", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 32, MoonName = "Thyone", MoonMass = "9", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.0015", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 33, MoonName = "Hermippe", MoonMass = "9", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.0015", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 34, MoonName = "Aitne", MoonMass = "4.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.0012", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 35, MoonName = "Eurydome", MoonMass = "4.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.0012", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 36, MoonName = "Euanthe", MoonMass = "4.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.0012", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 37, MoonName = "Euporie", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 38, MoonName = "Orthosie", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.00081", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 39, MoonName = "Sponde", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.00081", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 40, MoonName = "Kale", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.00081", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 41, MoonName = "Pasithee", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.00081", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 42, MoonName = "Hegemone", MoonMass = "4.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 43, MoonName = "Mneme", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 44, MoonName = "Aoede", MoonMass = "9", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 45, MoonName = "Thelxinoe", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 46, MoonName = "Arche", MoonMass = "4.15", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.0012", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 47, MoonName = "Kallichore", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 48, MoonName = "Helike", MoonMass = "9", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 49, MoonName = "Carpo", MoonMass = "4.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 50, MoonName = "Eukelade", MoonMass = "9", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 51, MoonName = "Cyllene", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 52, MoonName = "Kore", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 53, MoonName = "Herse", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 54, MoonName = "S/2003 J 2", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 55, MoonName = "Eupheme", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 56, MoonName = "S/2003 J 4", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 57, MoonName = "Eirene", MoonMass = "9", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 58, MoonName = "S/2003 J 9", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 59, MoonName = "S/2003 J 10", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 60, MoonName = "S/2003 J 12", MoonMass = "1", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 61, MoonName = "Philophrosyne", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 62, MoonName = "S/2003 J 16", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 63, MoonName = "S/2003 J 18", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 64, MoonName = "S/2003 J 19", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 65, MoonName = "S/2003 J 23", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.00081", PlanetId = 6, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 66, MoonName = "Mimas", MoonMass = "3.79", Perihelion = "181770", Aphelion = "189270", Temperature = "1.15", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 67, MoonName = "Enceladus", MoonMass = "1.08", Perihelion = "236830", Aphelion = "239066", Temperature = "1.61", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 68, MoonName = "Tethys", MoonMass = "6.18", Perihelion = "294589", Aphelion = "294648", Temperature = "0.985", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 69, MoonName = "Dione", MoonMass = "1.095", Perihelion = "376580", Aphelion = "378260", Temperature = "1.48", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 70, MoonName = "Rhea", MoonMass = "2.3", Perihelion = "526543", Aphelion = "527597", Temperature = "1.24", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 71, MoonName = "Titan", MoonMass = "1.3452", Perihelion = "1186680", Aphelion = "1257060", Temperature = "1.88", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 72, MoonName = "Hyperion", MoonMass = "5.6", Perihelion = "1466112", Aphelion = "1535756", Temperature = "0.55", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 73, MoonName = "Iapetus", MoonMass = "1.805", Perihelion = "3460068", Aphelion = "3661612", Temperature = "1.09", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 74, MoonName = "Phoebe", MoonMass = "8.292", Perihelion = "0", Aphelion = "0", Temperature = "1.64", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 75, MoonName = "Janus", MoonMass = "1.9", Perihelion = "0", Aphelion = "0", Temperature = "0.63", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 76, MoonName = "Epimetheus", MoonMass = "5.3", Perihelion = "0", Aphelion = "0", Temperature = "0.64", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 77, MoonName = "Helene", Perihelion = "0", Aphelion = "0", MoonMass = "null", Temperature = "1.3", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 78, MoonName = "Telesto", MoonMass = "1", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 79, MoonName = "Calypso", MoonMass = "6.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 80, MoonName = "Atlas", MoonMass = "7", Perihelion = "0", Aphelion = "0", Temperature = "0.5", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 81, MoonName = "Prometheus", MoonMass = "1.6", Perihelion = "0", Aphelion = "0", Temperature = "0.48", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 82, MoonName = "Pandora", MoonMass = "1.4", Perihelion = "0", Aphelion = "0", Temperature = "0.49", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 83, MoonName = "Pan", MoonMass = "4.95", Perihelion = "0", Aphelion = "0", Temperature = "0.42", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 84, MoonName = "Ymir", MoonMass = "3.97", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 85, MoonName = "Paaliaq", MoonMass = "7.25", Perihelion = "6908035", Aphelion = "23139965", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 86, MoonName = "Tarvos", MoonMass = "2.3", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 87, MoonName = "Ijiraq", MoonMass = "1.18", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 88, MoonName = "Suttungr", MoonMass = "2.3", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 89, MoonName = "Kiviuq", MoonMass = "2.79", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 90, MoonName = "Mundilfari", MoonMass = "2.3", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 91, MoonName = "Albiorix", MoonMass = "2.23", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 92, MoonName = "Skathi", MoonMass = "3.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 93, MoonName = "Erriapus", MoonMass = "6.8", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 94, MoonName = "Siarnaq", MoonMass = "4.35", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 95, MoonName = "Thrymr", MoonMass = "2.3", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 96, MoonName = "Narvi", MoonMass = "2.3", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 97, MoonName = "Methone", MoonMass = "2", Perihelion = "194421", Aphelion = "194459", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 98, MoonName = "Pallene", MoonMass = "6", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 99, MoonName = "Polydeuces", MoonMass = "1", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 100, MoonName = "Daphnis", MoonMass = "1", Perihelion = "0", Aphelion = "0", Temperature = "0.34", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 101, MoonName = "Aegir", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 102, MoonName = "Bebhionn", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 103, MoonName = "Bergelmir", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 104, MoonName = "Bestla", MoonMass = "2.3", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 105, MoonName = "Farbauti", MoonMass = "9", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 106, MoonName = "Fenrir", MoonMass = "5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 107, MoonName = "Fornjot", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 108, MoonName = "Hati", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 109, MoonName = "Hyrrokkin", MoonMass = "3.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 110, MoonName = "Kari", MoonMass = "2.3", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 111, MoonName = "Loge", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 112, MoonName = "Skoll", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 113, MoonName = "Surtur", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 114, MoonName = "Anthe", MoonMass = "5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 115, MoonName = "Jarnsaxa", MoonMass = "1", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 116, MoonName = "Greip", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 117, MoonName = "Tarqeq", MoonMass = "2.3", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 118, MoonName = "Aegaeon", MoonMass = "1", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 119, MoonName = "S/2004 S 7", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 120, MoonName = "S/2004 S 12", MoonMass = "9", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 121, MoonName = "S/2004 S 13", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 122, MoonName = "S/2004 S 17", MoonMass = "5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 123, MoonName = "S/2006 S 1", MoonMass = "1", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 124, MoonName = "S/2006 S 3", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 125, MoonName = "S/2007 S 2", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 126, MoonName = "S/2007 S 3", MoonMass = "1.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 127, MoonName = "S/2009 S 1", MoonMass = "1", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 7, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 128, MoonName = "Ariel", MoonMass = "12.9", Perihelion = "190670", Aphelion = "191130", Temperature = "1.59", Gravity = "0", PlanetId = 8, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 129, MoonName = "Umbriel", MoonMass = "12.2", Perihelion = "265100", Aphelion = "267500", Temperature = "1.46", Gravity = "0", PlanetId = 8, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 130, MoonName = "Titania", MoonMass = "34.2", Perihelion = "435800", Aphelion = "436800", Temperature = "1.66", Gravity = "0", PlanetId = 8, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 131, MoonName = "Oberon", MoonMass = "28.8", Perihelion = "582702", Aphelion = "584336", Temperature = "1.56", Gravity = "0", PlanetId = 8, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 132, MoonName = "Miranda", MoonMass = "6.6", Perihelion = "129703", Aphelion = "130041", Temperature = "1.2", Gravity = "0", PlanetId = 8, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 133, MoonName = "Cordelia", MoonMass = "4.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 8, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 134, MoonName = "Ophelia", MoonMass = "5.4", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 8, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 135, MoonName = "Bianca", MoonMass = "9.2", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 8, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 136, MoonName = "Cressida", MoonMass = "3.4", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 8, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 137, MoonName = "Desdemona", MoonMass = "1.8", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 8, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 138, MoonName = "Juliet", MoonMass = "5.6", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 8, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 139, MoonName = "Portia", MoonMass = "1.7", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 8, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 140, MoonName = "Rosalind", MoonMass = "0.25", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 8, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 141, MoonName = "Belinda", MoonMass = "4.9", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 8, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 142, MoonName = "Puck", MoonMass = "2.9", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 8, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 143, MoonName = "Caliban", MoonMass = "2.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 8, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 144, MoonName = "Sycorax", MoonMass = "2.3", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 8, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 145, MoonName = "Prospero", MoonMass = "8.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 8, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 146, MoonName = "Setebos", MoonMass = "7.5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 8, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 147, MoonName = "Stephano", MoonMass = "2.2", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 8, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 148, MoonName = "Trinculo", MoonMass = "3.9", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 8, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 149, MoonName = "Francisco", MoonMass = "7.2", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 8, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 150, MoonName = "Margaret", MoonMass = "5.4", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 8, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 151, MoonName = "Ferdinand", MoonMass = "5.4", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 8, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 152, MoonName = "Perdita", MoonMass = "1.8", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 8, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 153, MoonName = "Mab", MoonMass = "1", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 8, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 154, MoonName = "Cupid", MoonMass = "3.8", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 8, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 155, MoonName = "Triton", MoonMass = "2.14", Perihelion = "354753", Aphelion = "354765", Temperature = "2.05", Gravity = "0.78", PlanetId = 9, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 156, MoonName = "Nereid", MoonMass = "3", Perihelion = "1372000", Aphelion = "9655000", Temperature = "1", Gravity = "0.071", PlanetId = 9, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 157, MoonName = "Naiad", MoonMass = "2", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.01", PlanetId = 9, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 158, MoonName = "Thalassa", MoonMass = "4", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.013", PlanetId = 9, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 159, MoonName = "Despina", MoonMass = "2", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.023", PlanetId = 9, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 160, MoonName = "Galatea", MoonMass = "2", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.03", PlanetId = 9, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 161, MoonName = "Larissa", MoonMass = "5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.034", PlanetId = 9, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 162, MoonName = "Proteus", MoonMass = "5", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.075", PlanetId = 9, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 163, MoonName = "Halimede", MoonMass = "2", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.01", PlanetId = 9, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 164, MoonName = "Psamathe", MoonMass = "2", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 9, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 165, MoonName = "Sao", MoonMass = "1", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.01", PlanetId = 9, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 166, MoonName = "Laomedeia", MoonMass = "1", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0.01", PlanetId = 9, ImageLink = "", UserId = 1 },
                new Moon { MoonId = 167, MoonName = "Neso", MoonMass = "1", Perihelion = "0", Aphelion = "0", Temperature = "1", Gravity = "0", PlanetId = 9, ImageLink = "", UserId = 1 }
            );
        }
    }
}
