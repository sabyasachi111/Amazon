using DataLayer.DataContext;
using Microsoft.AspNetCore.Mvc;
using AmazonModel.Models;
using System.Collections.Generic;

namespace Amazon.Controllers
{
    public class HomeController : Controller
    {
        private readonly AmazonDbContext _context;
        public HomeController(AmazonDbContext dbContext)
        {
            _context= dbContext;
        }
        
        public IActionResult Index()
        {
            List<CatagoryModel> List =_context.StoreCatagory.ToList();
            return View( List);
        }
    }
}
