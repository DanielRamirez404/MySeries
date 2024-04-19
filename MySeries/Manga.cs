using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySeries.Classes
{
    public class Manga : Comic
    {
        public string Demography { get; set; }

        public Manga(string title, string author, string date, string genre, int rating, string rewiew, string publisher, int volumes, int pagesPerVolume, int chapters, string demography) : base(title, author, date, genre, rating, rewiew, publisher, volumes, pagesPerVolume, chapters)
        {
            this.Demography = demography;
        }
    }
}
