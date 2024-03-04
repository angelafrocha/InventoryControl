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

        [HttpGet]("{id}")
        public IActionResult GetById(Guid id)
        {

        }
        [HttpPost]("RegisterEntry")
        public IActionResult Post(Product product)
        {

        }

        [HttpPut] ("RegisterDeparture")
        public IActionResult Update()
        {

        }

        [HttpDelete] ("DiscardExpiredProducts")
        public IActionResult DiscardExpiredProducts()
        {

        }


    }
}
