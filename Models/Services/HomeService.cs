using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using System.Security.Claims;
using System.Text;
using TechnicalAssessmentRokov.Entities;
using TechnicalAssessmentRokov.Models.Interfaces;

namespace TechnicalAssessmentRokov.Models.Services
{
    public class HomeService : IHomeService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly string baseUri;

        public HomeService(HttpClient httpClient, IConfiguration configuration, IHttpContextAccessor contextAccessor)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _contextAccessor = contextAccessor;

            baseUri = $"{_contextAccessor.HttpContext?.Request.Scheme}://{_contextAccessor.HttpContext?.Request.Host}";
        }

        public async Task<List<Book>?> GetBooks()
        {
            string requestUri = $"{baseUri}/api/home/getbooks";

            try
            {
                var response = await _httpClient.GetAsync(requestUri);

                if (response.IsSuccessStatusCode)
                {
                    List<Book>? books = await response.Content.ReadFromJsonAsync<List<Book>>();
                    return books;
                }
                else if (response.StatusCode.Equals(HttpStatusCode.NotFound))
                {
                    return null;
                }
                else
                {
                    throw new HttpRequestException($"Failed to retrieve books. Status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to retrieve books.", ex);
            }
        }

        public async Task DeleteBook(int bookId)
        {
            string requestUri = $"{baseUri}/api/home/deletebook";

            try
            {
                var request = new HttpRequestMessage(HttpMethod.Post, requestUri);

                var userRoles = _contextAccessor.HttpContext.User.Claims
                    .Where(c => c.Type == ClaimTypes.Role)
                    .Select(c => c.Value)
                    .ToList();

                if (userRoles.Any())
                {
                    request.Headers.Add("X-User-Roles", string.Join(",", userRoles));
                }

                var requestBody = new { ID = bookId };
                var json = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                request.Content = content;

                var response = await _httpClient.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to delete book.", ex);
            }
        }
    }
}


