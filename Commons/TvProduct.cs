using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Commons
{
    public abstract class TvProduct
    {
        //public enum Type
        //{
        //    film, serial
        //}

        protected string _name;
        protected string _type;
        protected int _year;
        protected string _genre; 
        protected int _length;
        protected string _description;
        protected List<Review> _reviews;

        public TvProduct(string name, int year, string genre, int length, string description, List<Review> reviews)
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

        public void AddReview(Review review)
        {
            _reviews.Add(review);
        }

        public List<Review> GetReviews()
        {
            return _reviews;
        }

        public int GetYear()
        {
            return _year;
        }

        public string MyGetType()
        {
            return _type;
        }

        public abstract int GetLength();
        public abstract string MyToString();

        public string ReviewToString()
        {
            string aux = "";

            if (_reviews.Count() == 0)
            {
                return "";
            }

            foreach (Review review in _reviews)
            {
                aux += review.MyToString()  + "\n";
            }
            return aux;
        }

        public double AverageRating()
        {
            double aux = 0;
            foreach (Review review in _reviews)
            {
                aux += review.GetRating();
            }
            return aux / _reviews.Count();
        }
    }
}
