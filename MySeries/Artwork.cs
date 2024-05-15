using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MySeries.Classes
{
    public abstract class Artwork
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Date { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }
        public string Rewiew { get; set; }

        public Artwork(string title, string author, string date, string genre, int rating, string rewiew)
        {
            this.Title = title;
            this.Author = author;
            this.Date = date;
            this.Genre = genre;
            this.Rating = rating;
            this.Rewiew = rewiew;
        }

        public float GetStars()
        {
            return Rating * 0.5f;
        }

        public abstract string GetReference();
        public virtual string ToString()
        {
            return $"({Title}, {Author}, {Date}, {Genre}, {Rating}, {Rewiew})";
        }

        protected string GetBaseInfo()
        {
            string baseInfo = ToString();
            baseInfo = baseInfo.Substring(1, baseInfo.Length - 1);
            return baseInfo;
        }

        protected string GetAuthorLastName()
        {
            for (int i = 0; i < Author.Length; i++)
            {
                if (Author[i] == ' ')
                    return Author.Substring(Author.Length - i, 1);
            }

            return "";
        }

        protected string GetAuthorFirstName()
        {
            for (int i = 0; i < Author.Length; i++)
            {
                if (Author[i] == ' ')
                    return Author.Substring(0, i + 1);
            }

            return Author;
        }
    }
}
