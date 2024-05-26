using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MySeries.Classes
{
    public class Book : Artwork
    {
        public string Publisher { get; set; }
        public int Volumes { get; set; }
        public int PagesPerVolume { get; set; }
        protected float MinutesPerPage { get; set; }

        public Book(string title, string author, string date, string genre, int rating, string rewiew, string publisher, int volumes, int pagesPerVolume) : base(title, author, date, genre, rating, rewiew)
        {
            Publisher = publisher;
            Volumes = volumes;
            PagesPerVolume = pagesPerVolume;
            MinutesPerPage = 1.7f;
        }

        public Book(SqlDataReader row) : this(row.GetString(0), row.GetString(1), row.GetString(2), row.GetString(3), row.GetInt32(4), row.GetString(5), row.GetString(6), row.GetInt32(7), row.GetInt32(8))
        {

        }

        public virtual float GetSeriesReadingTime()
        {
            return Volumes * GetVolumeReadingTime();
        }

        public float GetVolumeReadingTime()
        {
            return MinutesPerPage * PagesPerVolume;
        }

        public override string GetReference()
        {
            string lastName = GetAuthorLastName();

            if (lastName == "")
                return GetAuthorFirstName() + " (" + Date + "). " + Title + ". " + Publisher;

            return lastName + ", " + GetAuthorFirstName()[0] + ". (" + Date + "). " + Title + ". " + Publisher;
        }

        public override string ToString()
        {
            return $"('{Title}', '{Author}', '{Date}', '{Genre}', {Rating}, '{Rewiew}', \'{Publisher}\', {Volumes}, {PagesPerVolume})";
        }
    }
}
