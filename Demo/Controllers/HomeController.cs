using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    //ContentResult contentResult = new ContentResult();
        //    //contentResult.Content = "Hello From Content Result";
        //    //return Content("Hello from Content Helper Method");

        //}

        //public string AboutUS()
        //{
        //    return "Hello From About us";
        //}

        //public ActionResult RedirectTo()
        //{
        //    //RedirectToAction();
        //    return Redirect("https://www.google.com");
        //}

        public IActionResult Index()
        {

        return View(); 
        }

        public IActionResult AboutUs()
        {

            return View();
        }

        public IActionResult Privacy()
        {

            return View();
        }

    }
}
