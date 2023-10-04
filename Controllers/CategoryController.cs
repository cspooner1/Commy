using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Commy.Models;
using Commy.Data;

namespace Commy.Controllers
{
    //https:localhost:123/api/Category
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CommyDBContext _context;
        public CategoryController(CommyDBContext context)
        {
            _context = context;
        }

        //GET: api/Category
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            var categories = _context.Category.ToList();
            return categories;
        }

        // PUT: api/Category/id#
        [HttpPut]
        public async Task<IActionResult> PutCategory(int id, Category category)
        {
            //pull existing Category using the id
            Category existingCategory = await _context.Category.FindAsync(id);

            //change the values of each property on exixtingCategory to match the body of the request (category)
            existingCategory.Name = category.Name;
            existingCategory.Description = category.Description;

            //save the changes using the dbcontext
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> CreateCategory(string Name, string Description)
        {
            Category category = new Category(Name, Description);
            _context.Category.Add(category);
            _context.SaveChanges();
            return Ok(category);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult>DeleteCategory(int id)
        {
            var category = await _context.Category.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CategoryExists(int id){
            return _context.Categories.Any(e => e.Id == id);
        }
    }
}

