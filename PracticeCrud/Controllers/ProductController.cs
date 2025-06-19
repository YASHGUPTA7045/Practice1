using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracticeCrud.Data;
using PracticeCrud.Model;

namespace PracticeCrud.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext context;
        public ProductController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var prods = await context.Products.ToListAsync();
            return Ok(prods);
        }
        [HttpPost]

        public async Task<IActionResult> CreateProduct(Product Products)
        {
            var obj = new Product
            {
                Id = Products.Id,
                Name = Products.Name,
                Price = Products.Price
            };
            context.Products.Add(obj);
            await context.SaveChangesAsync();
            return Ok(obj);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(int id, Product products)
        {
            var exist = await context.Products.FindAsync(id);
            if (exist == null)
            {
                return NotFound();

            }
            exist.Name = products.Name;
            exist.Price = products.Price;
            await context.SaveChangesAsync();
            return Ok(exist);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var exist = await context.Products.FindAsync(id);
            if (exist == null)
            {
                return NotFound();

            }
            context.Products.Remove(exist);
            await context.SaveChangesAsync();
            return Ok();

        }





    }
}
