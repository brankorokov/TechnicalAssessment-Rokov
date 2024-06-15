using Microsoft.AspNetCore.Authentication;
using TechnicalAssessmentRokov.Entities;

namespace TechnicalAssessmentRokov.Models.Interfaces
{
    public interface IAuthService
    {
        public Task<UserAccount?> GetUserAccountAsync(string userName);
        public Task AddUserAsync(UserAccount account);
    }
}
