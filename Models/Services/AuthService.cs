using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using System.Security.Claims;
using System.Text;
using TechnicalAssessmentRokov.Entities;
using TechnicalAssessmentRokov.Models.Interfaces;

namespace TechnicalAssessmentRokov.Models.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly string baseUri;

        public AuthService(HttpClient httpClient, IConfiguration configuration, IHttpContextAccessor contextAccessor)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _contextAccessor = contextAccessor;

            baseUri = $"{_contextAccessor.HttpContext?.Request.Scheme}://{_contextAccessor.HttpContext?.Request.Host}";
        }

        public async Task<UserAccount?> GetUserAccountAsync(string userName)
        {
            string requestUri = $"{baseUri}/api/auth/getUserAccount/{userName}";

            try
            {
                var response = await _httpClient.GetAsync(requestUri);

                if (response.IsSuccessStatusCode)
                {
                    UserAccount? userAccount = await response.Content.ReadFromJsonAsync<UserAccount>();
                    return userAccount;
                }
                else if (response.StatusCode.Equals(HttpStatusCode.NotFound))
                {
                    return null;
                }
                else
                {
                    throw new HttpRequestException($"Failed to retrieve user account. Status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to retrieve user account.", ex);
            }
        }

        public async Task AddUserAsync(UserAccount account)
        {
            string requestUri = $"{baseUri}/api/auth/addUserAccount";

            try
            {
                var response = await _httpClient.PostAsync(requestUri, new StringContent(JsonConvert.SerializeObject(account), Encoding.UTF8, "application/json"));
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
