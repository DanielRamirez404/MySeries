using MySeries.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySeries.Classes
{
    public class Comic : Book
    {
        public int Chapters { get; set; }

        public Comic(string title, string author, string date, string genre, int rating, string rewiew, string publisher, int volumes, int pagesPerVolume, int  chapters) : base(title, author, date, genre, rating, rewiew, publisher, volumes, volumes / chapters)
        {
            this.Chapters = chapters;
            this.MinutesPerPage = 0.45f;
        }

        public override float GetSeriesReadingTime()
        {
            return Volumes * GetVolumeReadingTime();
        }
    }
}
