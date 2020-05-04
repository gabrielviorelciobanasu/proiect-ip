using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons
{
    public class Movie : Type
    {
        public Movie(string name, int year, string genre, int length, string description, List<Review> reviews) : base(name, year, genre, length, description, reviews)
        {
        }

        override protected int GetLength()
        {
            return _length;
        }
    }
}
