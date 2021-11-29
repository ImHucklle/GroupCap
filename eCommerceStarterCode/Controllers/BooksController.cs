using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Claims;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        //GET: api/<ProductController>
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _context.Books;
            return Ok(products);
        }

        // GET api/product/{id}
        //[HttpGet("{Id}")]
        //public IActionResult GetSingleProduct(int id)
        //{
        //    var singleProduct = _context.Books.Where(p => p.Id == id);
        //    return Ok(singleProduct);
        //}

        // GET api/product/selling/{userId}
//        [HttpGet("selling/{userId}"), Authorize]
//        public IActionResult GetUserProductsForSale(string id)
//        {
//            var userId = User.FindFirstValue("id");
//#pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
//            //var usersProductsForSale = _context.Books.Include(p => p.UserId).Where(p => p.UserId == userId);
//#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast
//            //return Ok(usersProductsForSale);
//        }

        //// GET api/searchresults/searchterm
        //[HttpGet("searchresults{searchTerm}")]
        //public IActionResult GetSearchResults(string searchTerm)
        //{
        //    // get all products with search term in name
        //    var products = _context.Books.Include(b => b.Genre).ToList().Where(b => b.Name.ToLower().Contains(searchTerm.ToLower()));
        //    return Ok(products);
        //}

        // POST api/<ProductController>
        [HttpPost("create"), Authorize]
        public IActionResult Add([FromBody] Books bookToAdd)
        {
            Books newBook = new Books()
            {
                Title = bookToAdd.Title,
                Author = bookToAdd.Author,
                Genre = bookToAdd.Genre,
                ReleaseDate = bookToAdd.ReleaseDate,
                Description = bookToAdd.Description,
                Price = bookToAdd.Price,

            };
            //var book = _mapper.Map<Books>(bookToAdd);
            _context.Books.Add(newBook);
            _context.SaveChanges();
            return StatusCode(201, bookToAdd);
        }

        // PUT api/<ProductController>/5
        [HttpPut()]
        public void Put(int id, [FromBody] string value)
        {
        }

        //// DELETE api/<ProductController>/5
        //[HttpDelete("{productId}")]
        //public IActionResult Remove(int productId)
        //{
        //    var singleProduct = _context.Books.Where(p => p.Id == productId).SingleOrDefault();
        //    _context.Books.Remove(singleProduct);
        //    _context.SaveChanges();
        //    return Ok(singleProduct);
        //}
    }
}
