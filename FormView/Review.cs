﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormView
{
    class Review
    {
        private int _rating;
        private string _comment;

        public Review(int rating, string comment)
        {
            _rating = rating;
            _comment = comment;
        }

        public int GetRating()
        {
            return _rating; 
        }

        public string GetComment()
        {
            return _comment;
        }
    }
}