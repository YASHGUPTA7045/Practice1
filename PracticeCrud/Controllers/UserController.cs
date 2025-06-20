using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracticeCrud.Data;
using PracticeCrud.Model;
namespace PracticeCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext context;
        public UserController(AppDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAllUser()
        {
            var result = await context.Users.ToListAsync();
            return Ok(result);
        }
        [HttpPost]
        public async Task<ActionResult<IEnumerable<User>>> CreateUser(User Users)
        {
            context.Users.Add(Users);
            await context.SaveChangesAsync();
            return Ok(Users);
        }
        [HttpPut]
        public async Task<ActionResult> UpdateUser(int id, User Users)
        {
            var users = await context.Users.FindAsync(id);
            if (users == null)
            {
                return Ok(users);
            }
            users.Name = Users.Name;
            return Ok(users);

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var exist = await context.Users.FindAsync(id);
            if (exist == null)
            {
                return NotFound();

            }
            context.Users.Remove(exist);
            await context.SaveChangesAsync();
            return Ok();

        }
    }
}
