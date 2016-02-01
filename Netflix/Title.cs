using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    abstract class Title //: IEnumerable
    {
        public string title;
        public int rating;

       
        public Title(string title,int rating)
        {
            this.title = title;
            this.rating = rating;
        }

        // public IEnumerator GetEnumerator()
        //{
        //    foreach (Genres genres in getAllGenres())
        //    {
        //        yield return genres;
        //    }
        //}

        //static void getAllGenres()
        //{
        //    foreach (Genres genre in this)
        //    {
        //        Console.WriteLine(genre.title);
        //    }
        //}


        //public string GetEntertainmentTitle()
        //{
        //    Console.WriteLine("What is the show or movie you want to add to catalog?");
        //    this.title = Console.ReadLine();
        //    return title;
        //}
    }
}
