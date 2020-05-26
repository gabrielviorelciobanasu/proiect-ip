/**************************************************************************
 *                                                                        *
 *  File:        Review.cs                                                *
 *  Copyright:   (c) 2020, Sarbu Razvan-Cristian                          *
 *  Description:  Implementare clasa Review                               *       
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/

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
