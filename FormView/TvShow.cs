using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormView
{
    class TvShow : Type
    {
        private int _noOfEpisodes;
        private int _minsPerEpisode;

        public TvShow(string name, int year, string genre, int length, List<Review> reviews, int noOfEpisodes, int minsPerEpisode) 
            : base(name, year, genre, length, reviews)
        {
            _noOfEpisodes = noOfEpisodes;
            _minsPerEpisode = minsPerEpisode;
        }
        protected override int GetLength()
        {
            return _noOfEpisodes * _minsPerEpisode;
        }    
    }
}
