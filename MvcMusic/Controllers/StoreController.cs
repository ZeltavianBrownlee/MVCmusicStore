using MvcMusic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace MvcMusic.Controllers
{
    public class StoreController : Controller
    {
        //Instance of MusicStoreEntities Class
        MusicStoreEntities storeDB = new MusicStoreEntities();

        // GET: Store
        public ActionResult Index()
        {
            //Setup list of genres for Store index page
            var genres = storeDB.Genres.ToList();
           
            return View(genres);
        }//end method

        //GET: /Store/Browse?genre=Disco
        public ActionResult Browse(string genre)
        {

            //Retrieve Genre and its Associate Albums from database
            var genreModel = storeDB.Genres.Include("Albums").Single(g => g.Name == genre);

            return View(genreModel);
            
        }//end method

        //GET: /Store/Details/
        public ActionResult Details(int id)
        {
            //Retrieve the album id
            var album = storeDB.Albums.Find(id);

            return View(album);
        }//end method
    }//end class
}//end namespace
