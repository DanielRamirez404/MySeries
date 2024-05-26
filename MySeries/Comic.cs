using MySeries.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public Comic(SqlDataReader row) : this(row.GetString(0), row.GetString(1), row.GetString(2), row.GetString(3), row.GetInt32(4), row.GetString(5), row.GetString(6), row.GetInt32(7), row.GetInt32(8), row.GetInt32(9))
        {

        }

        public override float GetSeriesReadingTime()
        {
            return Volumes * GetVolumeReadingTime();
        }

        public override string ToString()
        {
            return $"('{Title}', '{Author}', '{Date}', '{Genre}', {Rating}, '{Rewiew}', '{Publisher}', {Volumes}, {PagesPerVolume}, {Chapters})";
        }
    }
}
