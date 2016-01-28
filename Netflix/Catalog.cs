using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    class Catalog
    {
        public List<Genres> myCatalogList;
        public Catalog(List <Genres>catalogList)
        {
            this.myCatalogList = catalogList;
        }

        public void AddToGenreList(List <Genres>myGenreList)
        {
            this.myCatalogList.AddRange(myGenreList);
        }

       
    }
}
