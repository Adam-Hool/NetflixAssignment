using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    class Program
    {
        static void Main(string[] args)
        {
            Genres all = new Genres();
            Genres romance = new Genres();
            Genres action = new Genres();
            Genres comody = new Genres();
            List<Genres> myCatalogList = new List<Genres>();
            Catalog MyCatalog = new Catalog(myCatalogList);

        }
    }
}
