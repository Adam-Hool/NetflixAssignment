using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    class TVShow : Title, IEnumerable
    {

        public List<Genres> TVGenreList;
        public List<Episode> TVEpisodeList;
        public int rating;
        public TVShow(string title, List<Genres> genreList, List<Episode> episodeList, int rating) : base(title, rating)
        {
            this.title = title;
            this.TVGenreList = genreList;
            this.TVEpisodeList = episodeList;
            this.rating = rating;

        }

        public List<Genres> getTVGenre()
        {
            return this.TVGenreList;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Genres genres in TVGenreList)
            {
                yield return genres;
            }

        }

        //public void SetGenresList()
        //{
        //    this
        //}




        //public void getlist()
        //{

        //    foreach (List<Genres> myCatalog in CatalogList())
        //    {
        //        Console.Write(number.ToString() + " ");
        //    }

        //    Console.ReadKey();
        //}

        //public static System.Collections.IEnumerable CatalogList()
        //{
        //    yield return 3;
        //    yield return 5;
        //    yield return 8;
        //}
    }
}
