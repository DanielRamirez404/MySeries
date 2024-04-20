using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
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
        public override string GetReference()
        {
            string lastName = GetAuthorLastName();

            if (lastName == "")
                return GetAuthorFirstName() + " (" + Date + "). " + Title + " [Video game]. " + DevelopmentCompany;

            return lastName + ", " + GetAuthorFirstName()[0] + " (" + Date + "). " + Title + " [Video game]. " + DevelopmentCompany;
        }
    }
}
