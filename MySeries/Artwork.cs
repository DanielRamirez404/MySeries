using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MySeries.Classes
{
    public class Artwork
    {
        protected string title;
        protected string author;
        protected string date;
        protected int rating;
        protected string rewiew;

        public Artwork(string title, string author, string date, int rating, string rewiew)
        {
            this.title = title;
            this.author = author;
            this.date = date;
            this.rating = rating;
            this.rewiew = rewiew;
        }

        float getStars()
        {
            return (float)rating * 0.5f;
        }

        void copy(Artwork original)
        {
            this.title = original.title;
            this.author = original.author;
            this.date = original.date;
            this.rating = original.rating;
            this.rewiew = original.rewiew;
        }

        void modify(string title, string author, string date, int rating, string rewiew)
        {
            this.title = title;
            this.author = author;
            this.date = date;
            this.rating = rating;
            this.rewiew = rewiew;
        }
    }
}
