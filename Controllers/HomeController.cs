using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechnicalAssessmentRokov.Data;
using TechnicalAssessmentRokov.Entities;

namespace TechnicalAssessmentRokov.Controllers
{
    [ApiController]
    public class HomeController : Controller
    {
        private readonly DataContext _dataContext;
        public HomeController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        [Route("/api/home/getbooks")]
        public async Task<IActionResult> GetBooks()
        {
            try
            {
                //Retrieve books from DB
                List<Book> books = await _dataContext.Books.ToListAsync();
                return books == null ? NotFound() : Ok(books);
            }
            catch(Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
