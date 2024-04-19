using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public override string GetCredits()
        {
            //todo
            return "";
        }

        public override string GetReference()
        {
            //todo
            return "";
        }
    }
}
