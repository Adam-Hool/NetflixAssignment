using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix
{
    public class Program
    {
        static void Main(string[] args)
        {
            Genres all = new Genres("all");
            Genres romance = new Genres("romance");
            Genres action = new Genres("action");
            Genres comody = new Genres("comody");

            List<Title> myCatalogList = new List<Title>();
            List<Genres> entertainmentGenre = new List<Genres>();
            List<Genres> comodyShow = new List<Genres>();
            List<Episode> That70sEpisodes = new List<Episode>();
           // var entertainmentGenre = new Tuple<Genres>(action);
            entertainmentGenre.Add(action);
            Movie LOTR = new Movie("Lord of The Rings", entertainmentGenre, 283, 9);
            Episode piolet = new Episode("piolet", comodyShow, 7);
            That70sEpisodes.Add(piolet);
            TVShow That70sShow = new TVShow("That 70's Show", comodyShow,That70sEpisodes,8);
            myCatalogList.Add(LOTR);
            myCatalogList.Add(That70sShow);
            Catalog myCatalog = new Catalog(myCatalogList);
            myCatalog.AddEntertainmentToGenreList(myCatalogList);
            foreach(Genres genre in LOTR)
            {
                Console.WriteLine(genre.title);
            }
            //getList());
            Console.WriteLine("The Show '{0}' your on episode '{1}' and it has a rating of '{2}'",That70sShow.title, That70sShow.TVEpisodeList[0].title,That70sShow.rating);
            Console.WriteLine("The Movie '{2}' is a '{0}' genre and is '{1}' minutes long and has a rating of '{3}'",LOTR.MovieGenreList[0].title, LOTR.MovieLength, LOTR.title, LOTR.rating);
            Console.ReadLine();


        }
}
}
