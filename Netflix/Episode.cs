using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    public class Episode : Title
    {
        public Episode(string title, List<Genres> genreList, int rating) : base(title, rating)
        {
            this.title = title;
        }
    }
}
