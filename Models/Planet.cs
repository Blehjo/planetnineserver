using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace planetnineserver.Models
{
	public class Planet
	{
		public int PlanetId { get; set; }

		public string PlanetName { get; set; }

		public float PlanetMass { get; set; }

		public float Perihelion { get; set; }

		public float Aphelion { get; set; }

		public float Gravity { get; set; }

		public int Temperature { get; set; }

        public string Type { get; set; } = "planet";

        public string ImageLink { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }

        [NotMapped]
        public string? ImageSource { get; set; }

        public ICollection<Moon>? Moons { get; set; }

		public ICollection<Favorite>? Favorites { get; set; }
	}
}

