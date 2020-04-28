using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormView
{
    abstract class Type
    {
        protected string _name;
        protected int _year;
        protected string _genre;
        protected int _length;
        protected List<Review> _reviews;

        public Type(string name, int year, string genre, int length, List<Review> reviews) 
        {
            _name = name;
            _year = year;
            _genre = genre;
            _length = length;
            _reviews = reviews;
        }

        public string GetGenre()
        {
            return _genre;
        }
       
        public string GetName()
        {
            return _name;
        }

        public List<Review> GetReviews()
        {
            return _reviews;
        }

        public int GetYear()
        {
            return _year;
        }
        protected abstract int GetLength();
    }
}
