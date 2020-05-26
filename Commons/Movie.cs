/**************************************************************************
 *                                                                        *
 *  File:        Movie.cs                                                 *
 *  Copyright:   (c) 2020, Sarbu Razvan-Cristian                          *
 *  Description:  Implementare clasa Movie                                *       
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
                   "Rating: " + AverageRating();
        }
    }
}
