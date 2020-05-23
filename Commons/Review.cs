using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons
{
    public class Review
    {   
        private int _rating;
        private string _comment;
        private string _autor;

        public Review(int rating, string comment, string autor)
        {
            _rating = rating;
            _comment = comment;
            _autor = autor;
        }

        public int GetRating()
        {
            return _rating;
        }

        public string GetComment()
        {
            return _comment;
        }
        private string GetAutor()
        {
            return _autor;
        }

        public string MyToString()
        {
            return "Nota: " + GetRating() + "\n" +
                "Comentariu: " + GetComment() + "\n" +
                "Postat de: " + GetAutor() + "\n";
        }
    }
}
