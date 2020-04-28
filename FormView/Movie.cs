using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormView
{
    class Movie : Type
    {
        public Movie(string name, int year, string genre, int length, List<Review> reviews) : base(name, year, genre, length, reviews)
        {      
        }
        
        override protected int GetLength()
        {
            return _length;
        }
    }
}
