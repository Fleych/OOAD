using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCatalog
{
    internal class Film
    {
        public int id { get; set; }
        public string name { get; set; }
        public string genre { get; set; }
        public string description { get; set; }
        public Image image { get; set; }
        
        public Film(int id, string name, string genre, string description, Image image)
        {
            this.id = id;
            this.name = name;
            this.genre = genre;
            this.description = description;
            this.image = image;
        }
    }
}
