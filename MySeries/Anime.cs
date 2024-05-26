using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySeries.Classes
{
    public class Anime : Cinema
    {
        public string Studio { get; set; }
        public Anime(string title, string author, string date, string genre, int rating, string rewiew, int chapters, int duration, string studio) : base(title, author, date, genre, rating, rewiew, chapters, duration)
        {
            this.Studio = studio;
        }

        public Anime(SqlDataReader row) : this(row.GetString(0), row.GetString(1), row.GetString(2), row.GetString(3), row.GetInt32(4), row.GetString(5), row.GetInt32(6), row.GetInt32(7), row.GetString(8))
        {

        }

        public override string GetCredits()
        {
            return "Made by:\n"
                + "Author: " + Author + "\n"
                + "Animation Studio: " + Studio;
        }

        public override string GetReference()
        {
            string lastName = GetAuthorLastName();

            if (lastName == "")
                return GetAuthorFirstName() + " (" + Date + "). " + Title + " [Anime]. " + Studio;

            return lastName + ", " + GetAuthorFirstName()[0] + " (" + Date + "). " + Title + " [Anime]. " + Studio;
        }

        public override string ToString()
        {
            return $"('{Title}', '{Author}', '{Date}', '{Genre}', {Rating}, '{Rewiew}', {Chapters}, {ChapterDuration}, '{Studio}')";
        }
    }
}
