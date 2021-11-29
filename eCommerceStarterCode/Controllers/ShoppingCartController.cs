using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ShoppingCartController(ApplicationDbContext context)
        {
            _context = context;
        }

                //[HttpGet, Authorize]
                //public IActionResult GetShoppingCartForUser()
                //{
                //    var userID = User.FindFirstValue("id");
                //    var user = _context.Users.Find(userID);
                //    if (user == null)
                //    {
                //        return NotFound("User Not Found");
                //    }

                //    var shoppingCart = _context.ShoppingCart
                //        .Where(sc => sc.UserId == userID)
                //        .ToList();
                //    return Ok(shoppingCart);
                //}

        [HttpPost, Authorize]
        public IActionResult AddBookToShoppingCart()
        {
            var userId = User.FindFirstValue("id");
            var user = _context.Users.Find(userId);
            if (user == null)
            {
                return NotFound();
            }

            var bookId = _context.Books.Where(b => b.Title == "book").Select(b => b.BookId).SingleOrDefault();

            ShoppingCart newProduct = new ShoppingCart()
            {
                UserId = userId,
                BookId = bookId,
                Quantity = 1,
            };

            _context.ShoppingCart.Add(newProduct);
            _context.SaveChanges();
            return StatusCode(201);

        }

        [HttpPut]
        public IActionResult EditShoppingCart([FromBody] ShoppingCart shoppingCartToChange) 
        {
            _context.ShoppingCart.Update(shoppingCartToChange);
      
            _context.SaveChanges();
            return StatusCode(201);
        }

        [HttpDelete, Authorize]
        public IActionResult RemoveBookFromShoppingCart()
        {
            var BookToBeRemoved = "bookId";
            var BookDelete = _context.ShoppingCart.Where(sc => sc.Books.Title == BookToBeRemoved).SingleOrDefault();
            _context.ShoppingCart.Remove(BookDelete);
            _context.SaveChanges();
            return Ok();
        }
    }
}

