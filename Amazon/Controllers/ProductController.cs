using AmazonModel.Models;
using DataLayer.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace Amazon.Controllers
{
    public class ProductController : Controller
    {
        private readonly AmazonDbContext _context;
        public ProductController(AmazonDbContext dbContext)
        {
            _context= dbContext;
        }
        [HttpGet]
        public IActionResult GetAllProduct()
        {

            List<StoreProductsModel> products=_context.StoreProducts.ToList();
            return View(products);
        }
        [HttpGet]
        public IActionResult ProductDetails(int? ID) {
            if (ID == null)
            {
                return BadRequest(ModelState);
            }
            
                StoreProductsModel product = _context.StoreProducts.FirstOrDefault(x => x.ProductID == ID);
            
            return View(product);
        }


        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();  
        }
        [HttpPost]
        public IActionResult AddProduct([FromForm] StoreProductsModel product) {

            if(product == null)
            {
                return BadRequest(ModelState);
            }
             _context.StoreProducts.Add(product);
            _context.SaveChanges();
            return RedirectToAction("GetAllProduct");
        }
    }
}
