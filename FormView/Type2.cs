using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormView
{
    interface Type2
    {


        List<Review> GetReviews();
        string GetGenre();
        string GetName();
        int GetYear();
        int GetLength();
    
    }
}
