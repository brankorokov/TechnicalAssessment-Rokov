using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using TechnicalAssessmentRokov.Data;
using TechnicalAssessmentRokov.Entities;

namespace TechnicalAssessmentRokov.Controllers
{
    /** 
     * - This is the API controller which will access our dataContext and make changes to the data.
     * - We authorize based on a policy that we've set up in the Program.cs file. This just checks if the user is registered as a customer or librarian. i.e they have an account.
     **/
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Policy = "LibraryMember")]
    public class LibraryController : Controller
    {
        private readonly DataContext _dataContext;
        private readonly IHttpContextAccessor _contextAccessor;
        public LibraryController(DataContext dataContext, IHttpContextAccessor contextAccessor)
        {
            _dataContext = dataContext;
            _contextAccessor = contextAccessor;
        }

        [HttpGet("getbooks")]
        [Authorize]
        public async Task<IActionResult> GetBooks()
        {
            try
            {
                List<Book> books = await _dataContext.Books
                    .Include(b => b.CheckedOutByUser)
                    .ToListAsync();

                return books == null ? NotFound() : Ok(books);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("deletebook")]
        [Authorize(Roles = "LIBRARIAN")]
        public async Task<IActionResult> DeleteBook(Book book)
        {

            HttpContext context = HttpContext;
            try
            {

                if (book == null)
                {
                    return NotFound();
                }

                _dataContext.Books.Remove(book);
                await _dataContext.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("addbook")]
        [Authorize(Roles = "LIBRARIAN")]
        public async Task<IActionResult> AddBook(Book book)
        {
            try
            {
                if (book == null)
                {
                    return NotFound();
                }

                _dataContext.Books.Add(book);
                await _dataContext.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("updatebook")]
        [Authorize(Roles = "LIBRARIAN")]
        public async Task<IActionResult> UpdateBook(Book book)
        {
            try
            {
                if (book == null)
                {
                    return NotFound();
                }

                _dataContext.Books.Update(book);
                await _dataContext.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("checkoutbook")]
        [Authorize(Roles = "CUSTOMER")]
        //For some reason when I access the user name from the context accessor it is always null. Going to just pass the username as a parameter for now.
        public async Task<IActionResult> CheckoutBook([FromBody] Book Book)
        {
            try
            {
                if (Book == null)
                {
                    return NotFound();
                }
                var name = _contextAccessor.HttpContext?.User.Identity?.Name;
                Book.CheckedOutDate = DateTime.Now;
                Book.DueDate = DateTime.Now.AddDays(5);

                //We've established this as a foreign key in the DataContext.cs file and validate the user name as unique in the sign up flow.
                Book.CheckedOutByUser = _dataContext.Users
                                        .Where(u => u.UserName == name)
                                        .FirstOrDefault();


                _dataContext.Books.Update(Book);
                await _dataContext.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("checkinbook")]
        [Authorize(Roles = "LIBRARIAN")]
        public async Task<IActionResult> CheckInBook(Book book)
        {
            try
            {
                if (book == null)
                {
                    return NotFound();
                }

                book.CheckedOutDate = null;
                book.DueDate = null;
                book.CheckedOutByUserId = null;
                book.CheckedOutByUser = null;

                _dataContext.Books.Update(book);
                await _dataContext.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
