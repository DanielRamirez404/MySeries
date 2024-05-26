using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public Manga(SqlDataReader row) : this(row.GetString(0), row.GetString(1), row.GetString(2), row.GetString(3), row.GetInt32(4), row.GetString(5), row.GetString(6), row.GetInt32(7), row.GetInt32(8), row.GetInt32(9), row.GetString(10))
        {

        }

        public override string ToString()
        {
            return $"({Title}', '{Author}', '{Date}', '{Genre}', {Rating}, '{Rewiew}', '{Publisher}', {Volumes}, {PagesPerVolume}, {Chapters}, \'{Demography}\')";
        }
    }
}
