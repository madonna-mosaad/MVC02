using Microsoft.AspNetCore.Mvc;

namespace MVC02.Controllers
{
    public class MovieController: Controller
    {
        public IActionResult GetMovie(int id)
        {
            return Content($"Movie with id = {id}");
        }
        [ActionName("ToGetMethod")]
        public IActionResult Index(int Id)
        {
            return RedirectToAction("GetMovie", new { id = Id });
        }
    }
}
