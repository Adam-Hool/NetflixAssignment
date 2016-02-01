using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    public class Movie : Title 
    {
        public List<Genres> MovieGenreList;
        public int MovieLength;
        public Movie(string title, List<Genres>genreList, int lenght, int rating) : base(title, rating)//, genreList)
        {
            this.title = title;
            this.MovieGenreList = genreList;
            this.MovieLength = lenght;
        }



        public IEnumerator GetEnumerator()
        {
            foreach (Genres genres in MovieGenreList)
            {
                yield return genres;
            }

        }
        //public void getList()
        //{

        //    foreach (List<Genres> myCatalog in CatalogList())
        //    {
        //        Console.WriteLine(myCatalog.ToString() + " ");
        //    }

        //    Console.ReadKey();
        //}

        //public System.Collections.IEnumerable CatalogList()
        //{
        //    yield return getMovieGenre();
        //    //yield return getMovieGenre();
        //    //yield return getMovieGenre();
        //}
    }
}
