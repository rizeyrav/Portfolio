using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using System.Collections.Generic;
// using Portfolio.Repositories

namespace Portfolio.Controllers{
    public class Profile : Controller{
        private readonly PortfoliodbContext _context;

        public Profile (PortfoliodbContext context){
            _context = context;
        }

        public IActionResult Index(){
            return View();
        }

        public IActionResult Create(){
            return View();
        }
    }
}