using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons
{
    public class TvShow : Type
    {
        private int _noOfEpisodes;
        private int _minsPerEpisode;

        public TvShow(string name, int year, string genre, int length, string description, List<Review> reviews, int noOfEpisodes, int minsPerEpisode)
            : base(name, year, genre, length, description, reviews)
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
