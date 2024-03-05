using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationInventory.Entity;
using WebApplicationInventory.Persistence;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApplicationInventory.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        public readonly InventoryDbContext _context;

        public InventoryController(InventoryDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var procucts = _context.Products;

            return Ok(procucts);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }


        [HttpPost("RegisterEntry")]
        public IActionResult Post(Product product)
        {
            _context.Products.Add(product);

            return CreatedAtAction(nameof(GetById), new { id = product.Id}, product);

        }

        [HttpPut("Id")]
        public IActionResult Update(Guid id, int quantity)
        {
            var product = _context.Products.SingleOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }
            else if (product != null && product.Quantity >= quantity)
            {
                product.Quantity -= quantity;

                return Ok($"Withdrawal of {quantity} units of product {product.Name} completed.");
            }
            else
            {
                return BadRequest("Insufficient stock to fulfill the request.");
            }
        }

        //[HttpDelete("DiscardExpiredProducts")] 
        //public IActionResult DiscardExpiredProducts()
        //{
        //    var product = _context.Products.Where(p => p.ExpirationDate < DateTime.Now);

        //    if (products.Count == 0)
        //    {
        //        return NotFound("No expired products found.");
        //    }

        //    product.Delete();

        //    return Ok($"Discarded expired products.");
        //}

    }


    }
}
