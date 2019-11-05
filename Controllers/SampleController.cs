using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class SampleController : Controller
    {
        private readonly MvcMusicStoreContext _context;

        public SampleController(MvcMusicStoreContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var mvcMusicStoreContext = _context.Album.Include(a => a.Artist).Include(a => a.Genre)
                                       .Select(a=>new AlbumArtist
                                        {
                                            Album=a.Title,
                                            Artist=a.Artist.Name
                                        }).Take(10);
            //var albumArtists = new List<AlbumArtist>();
            //foreach (Album item in mvcMusicStoreContext)
            //{                
            //    albumArtists.Add(new AlbumArtist(item.Title,item.Artist.Name) );
            //}
            //var list = mvcMusicStoreContext.ToListAsync();
            return View(mvcMusicStoreContext);
            //return View();
        }
    }
}