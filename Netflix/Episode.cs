using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    class Episode : Title
    {
        public Episode(string title, List<Genres> genreList, List<string> episodes) : base(title, genreList)
        {
        }
    }
}
