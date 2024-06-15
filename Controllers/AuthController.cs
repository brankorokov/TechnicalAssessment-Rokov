using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechnicalAssessmentRokov.Data;
using TechnicalAssessmentRokov.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechnicalAssessmentRokov.Controllers
{
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public AuthController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        [Route("/api/auth/getUserAccount/{userName}")]
        public async Task<ActionResult> GetUserAccount(string userName)
        {
            UserAccount? userAccount = await _dataContext.UserAccounts.Where(x => x.UserName == userName).FirstOrDefaultAsync();

            return userAccount == null ? NotFound() : Ok(userAccount);
        }

        [HttpPost]
        [Route("/api/auth/addUserAccount")]
        public async Task<ActionResult> AddUserAccount([FromBody] UserAccount account)
        {
            try
            {
                _dataContext.UserAccounts.Add(account);

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
