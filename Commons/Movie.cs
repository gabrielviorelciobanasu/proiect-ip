using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons
{
    public class Movie : TvProduct
    {
        public Movie(string name, int year, string genre, int length, string description, List<Review> reviews) : base(name, year, genre, length, description, reviews)
        {
            base._type = "Film";
        }

        override public int GetLength()
        {
            return _length;
        }

        public override string MyToString()
        {
            return "Nume film: " + GetName() + "\n" +
                   "An apariție: " + GetYear() + "\n" +
                   "Gen: " + GetGenre() + "\n" +
                   "Durată: " + GetLength() + " minute \n" +
                   "Descriere: " + GetDescription() + "\n" +
                   "Rating: " + AverageRating().ToString("0.0");
        }
    }
}
