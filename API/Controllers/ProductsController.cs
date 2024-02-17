using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;

        public ProductsController(StoreContext context){
            _context = context;
        }

        [HttpGet]

        public async Task <ActionResult<List<Product>>> GetProducts()
        {
            return await _context.Products.ToListAsync();

        } 

        [HttpGet("{id}")]

        public async Task <ActionResult<Product>> GetProduct(int id){
            return await _context.Products.FindAsync(id);
        }

         [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                // Add the new product to the database
                _context.Products.Add(product);
                await _context.SaveChangesAsync();

                // Return the newly created product
                return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
            }

            // If the input data is not valid, return a bad request
            return BadRequest(ModelState);
        }   
    }
}