using eCommerceStarterCode.Data;
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

        [HttpGet, Authorize]
        public IActionResult GetShoppingCartForUser()
        {
            var userID = User.FindFirstValue("id");
            var user = _context.Users.Find(userID);
            if (user == null)
            {
                return NotFound("User Not Found");
            }

            var shoppingCart = _context.ShoppingCart
                .Where(sc => sc.UserId == userID)
                .ToList();
            return Ok(shoppingCart);
        }
    }
}
