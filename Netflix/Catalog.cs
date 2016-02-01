using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    public class Catalog 
    {
        public List<Title> myCatalogList;
        public Catalog(List<Title>catalogList) 
        {
            this.myCatalogList = catalogList;
        }

        public void AddEntertainmentToGenreList(List<Title>myGenreList)
        {
            this.myCatalogList.AddRange(myGenreList);
        }
    
       //public List<Genres> GetGenreList()
       // {
       //     return this.myCatalogList;
       // }
    
    }
}
