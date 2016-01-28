using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    class TVShow : Title
    {
        public TVShow(string title, List<Genres> genreList, List<Episode> episodeList) : base(title, genreList)
        {
        }
    }
}
