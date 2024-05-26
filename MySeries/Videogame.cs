using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MySeries.Classes
{
    public class Videogame : Artwork
    {
        public string DevelopmentCompany { get; set; }
        public string Console { get; set; }

        public Videogame(string title, string author, string date, string genre, int rating, string rewiew, string developmentCompany, string console) : base(title, author, date, genre, rating, rewiew)
        {
            DevelopmentCompany = developmentCompany;
            Console = console;
        }

        public Videogame(SqlDataReader row) : this(row.GetString(0), row.GetString(1), row.GetString(2), row.GetString(3), row.GetInt32(4), row.GetString(5), row.GetString(6), row.GetString(7))
        {

        }

        public override string GetReference()
        {
            string lastName = GetAuthorLastName();

            if (lastName == "")
                return GetAuthorFirstName() + " (" + Date + "). " + Title + " [Video game]. " + DevelopmentCompany;

            return lastName + ", " + GetAuthorFirstName()[0] + " (" + Date + "). " + Title + " [Video game]. " + DevelopmentCompany;
        }

        public override string ToString()
        {
            return $"('{Title}', '{Author}', '{Date}', '{Genre}', {Rating}, '{Rewiew}', \'{DevelopmentCompany}\', \'{Console}\')";
        }
    }
}
