using System.ComponentModel.DataAnnotations.Schema;

namespace planetnineserver.Models
{
	public class Moon
	{
		public int MoonId { get; set; }
        
        public string MoonName { get; set; }

        public float MoonMass { get; set; }

        public float Perihelion { get; set; }

        public float Aphelion { get; set; }

        public float Gravity { get; set; }

        public int Temperature { get; set; }

        public string Type { get; set; } = "moon";

        public string ImageLink { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }

        [NotMapped]
        public string? ImageSource { get; set; }

        public int PlanetId { get; set; }

        public Planet? Planet { get; set; }

        public ICollection<Favorite>? Favorites { get; set; }
    }
}

