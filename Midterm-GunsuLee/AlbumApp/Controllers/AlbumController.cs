using AlbumApp.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AlbumApp.Controllers
{
    public class AlbumController : Controller
    {
        private AlbumsDbContext _albumsDbContext;

        public AlbumController(AlbumsDbContext albumsDbContext)
        {
            _albumsDbContext = albumsDbContext;
        }


        [HttpGet("/all-albums")]
        public IActionResult Items()
        {
            var albums = _albumsDbContext.Albums.OrderByDescending(a => a.Rating).ToList();
            return View("Items", albums);
        }

        [HttpGet("/albums/add-album")]
        public IActionResult GetAddAlbum()
        {
            return View("Add", new Album());
        }

        [HttpPost("/albums")]
        public IActionResult AddNewAlbum(Album album)
        {
            if(ModelState.IsValid)
            {
                _albumsDbContext.Albums.Add(album);
                _albumsDbContext.SaveChanges();
                TempData["LastActionMessage"] = "Creation was successful";

                return RedirectToAction("Items");
            }
            else
            {
                return View("Add", album);
            }
        }


        [HttpGet("/albums/{id}")]
        public IActionResult GetAlbumById(int id)
        {
            var album = _albumsDbContext.Albums.Find(id);
            return View("Item", album);
        }


        [HttpGet("/albums/{id}/edit-album")]
        public IActionResult GetEditAlbumById(int id)
        {
            var album = _albumsDbContext.Albums.Find(id);
            return View("Edit", album);
        }

        [HttpPost("/albums/{id}/edit-request")]
        public IActionResult EditAlbumRequest(int id, Album album)
        {
            if (id != album.AlbumId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _albumsDbContext.Albums.Update(album);
                _albumsDbContext.SaveChanges();
                TempData["LastActionMessage"] = $"The Album \"{album.Title}\" has been updated successfully";

                return RedirectToAction("Items", "Album");
            }
            else
            {
                return View("Edit", album);
            }
        }
    }
}
