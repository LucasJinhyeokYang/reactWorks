using Microsoft.AspNetCore.Mvc;

namespace ExerciseTwo.Controllers{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            return View();
        }

        public  string Test(string id)
        {
            return id;
        }
    }
}