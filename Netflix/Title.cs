using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    abstract class Title : Genres
    {
        public string title;


        public Title(string title, List <Genres> genreList)
        {
            this.title = title;
        }
    }
}
