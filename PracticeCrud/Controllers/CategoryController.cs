using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracticeCrud.Data;
using PracticeCrud.Model;

namespace PracticeCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly AppDbContext context;
        public CategoryController(AppDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetAllCategory()
        {

            var results = await context.categories.ToListAsync();
            return Ok(results);
        }

        [HttpPost]
        public async Task<ActionResult<Category>> CreateCategory(Category category)
        {
            context.categories.Add(category);
            await context.SaveChangesAsync();
            return Ok(category);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategory(int id, Category category)
        {
            var result = await context.categories.FindAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            result.CategoryName = category.CategoryName;
            await context.SaveChangesAsync();
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategoryt(int id)
        {
            var exist = await context.categories.FindAsync(id);
            if (exist == null)
            {
                return NotFound();

            }
            context.categories.Remove(exist);
            await context.SaveChangesAsync();
            return Ok();

        }



    }
}
