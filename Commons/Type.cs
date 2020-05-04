using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons
{
    public abstract class Type
    {
        protected string _name;
        protected int _year;
        protected string _genre;
        protected int _length;
        protected string _description;
        protected List<Review> _reviews;

        public Type(string name, int year, string genre, int length, string description, List<Review> reviews)
        {
            _name = name;
            _year = year;
            _genre = genre;
            _length = length;
            _reviews = reviews;
            _description = description;
        }

        public string GetGenre()
        {
            return _genre;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetDescription()
        {
            return _description;
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
