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
            base._type = "tvshow";
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
                   "Durată totală: " + GetLength() + "\n" +
                   "Descriere: " + GetDescription() + "\n" +
                   "Rating mediu: " + AverageRating().ToString("0.0");
        }
    }
}
