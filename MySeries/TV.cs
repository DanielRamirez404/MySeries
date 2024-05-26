using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MySeries.Classes
{
    public class TV : Cinema
    {
        public string Director { get; set; }
        public string Producer { get; set; }

        public TV(string title, string author, string date, string genre, int rating, string rewiew, int chapters, int duration, string director, string producer) : base(title, author, date, genre, rating, rewiew, chapters, duration)
        {
            this.Director = director;
            this.Producer = producer;
        }

        public TV(SqlDataReader row) : this(row.GetString(0), row.GetString(1), row.GetString(2), row.GetString(3), row.GetInt32(4), row.GetString(5), row.GetInt32(6), row.GetInt32(7), row.GetString(8), row.GetString(9))
        {

        }

        public override string GetCredits()
        {
            return "Made by:\n"
                + "Author: " + Author + "\n"
                + "Director: " + Director + "\n"
                + "Producer: " + Producer;
        }

        public override string GetReference()
        {
            string lastName = GetAuthorLastName();

            if (lastName == "")
                return GetAuthorFirstName() + " (" + Director + "). " + " (" + Date + "). " + Title + " [Film]. " + Producer;

            return lastName + ", " + GetAuthorFirstName()[0] + " (" + Director + "). " + " (" + Date + "). " + Title + " [Film]. " + Producer;
        }

        public override string ToString()
        {
            return $"('{Title}', '{Author}', '{Date}', '{Genre}', {Rating}, '{Rewiew}', {Chapters}, {ChapterDuration}, \'{Director}\', \'{Producer}\')";
        }
    }
}
