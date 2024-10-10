using AmazonModel.Models;
using DataLayer.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace Amazon.Controllers
{
   

    public class CartController : Controller
    {
        private readonly AmazonDbContext _context;
        public CartController(AmazonDbContext dbContext)
        {
            _context= dbContext;
        }
        [HttpGet] 
        public IActionResult CartDetails(int? Id)
        {
            if (Id == null)
            {
                return BadRequest();    
            }
            var product=_context.StoreProducts.FirstOrDefault(x => x.ProductID==Id);
            CartModel cart= new CartModel();
            cart.P
            return View(product);
        }
    }
}
