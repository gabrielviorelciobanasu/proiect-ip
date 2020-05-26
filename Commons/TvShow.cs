/**************************************************************************
 *                                                                        *
 *  File:        TvShow.cs                                                *
 *  Copyright:   (c) 2020, Sarbu Razvan-Cristian                          *
 *  Description:  Implementare clasa TvShow                               *       
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
    public class TvShow : TvProduct
    {
        private int _noOfEpisodes;
        private int _minsPerEpisode;

        public TvShow(string name, int year, string genre, int length, string description, List<Review> reviews, int noOfEpisodes, int minsPerEpisode)
            : base(name, year, genre, length, description, reviews)
        {
            _noOfEpisodes = noOfEpisodes;
            _minsPerEpisode = minsPerEpisode;
            base._type = "Serial";
        }
        public override int GetLength()
        {
            return _noOfEpisodes * _minsPerEpisode;
        }

        public override string MyToString()
        {
            return "Nume serial: " + GetName() + "\n" +
                   "An apariție: " + GetYear() + "\n" +
                   "Gen: " + GetGenre() + "\n" +
                   "Număr de episoade: " + _noOfEpisodes + "\n" +
                   "Durată episod: " + _minsPerEpisode + " minute \n" +
                   "Durată totală: " + GetLength() + " minute \n"+
                   "Descriere: " + GetDescription() + "\n" +
                   "Rating mediu: " + AverageRating();
        }
    }
}
