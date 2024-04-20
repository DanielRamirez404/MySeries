using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MySeries.Classes
{
    public abstract class Cinema : Artwork
    {
        protected int Chapters { get; set; }
        protected int ChapterDuration { get; set; }

        protected Cinema(string title, string author, string date, string genre, int rating, string rewiew, int chapters, int duration) : base(title, author, date, genre, rating, rewiew)
        {
            this.Chapters = chapters;
            this.ChapterDuration = duration;
        }

        public abstract string GetCredits();

        protected int GetTotalDuration()
        {
            return Chapters * ChapterDuration;
        }
    }
}
