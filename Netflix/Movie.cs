using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    class Movie : Title 
    {
        public Movie(string title, List<Genres>genreList) : base(title, genreList)
        {

        }
    }
}
