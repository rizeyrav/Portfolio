using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers{
    public class Profile : Controller{
        public IActionResult Index(){
            return View();
        }
        public IActionResult Create(){
            return View();
        }
    }
}