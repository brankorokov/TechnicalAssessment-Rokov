using Azure.Core;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security;
using System.Security.Claims;
using System.Text;
using TechnicalAssessmentRokov.Entities;
using TechnicalAssessmentRokov.Models.Interfaces;
using static System.Net.WebRequestMethods;

namespace TechnicalAssessmentRokov.Models.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly string baseUri;

        public LibraryService(IHttpClientFactory httpClientFactory, IConfiguration configuration, IHttpContextAccessor contextAccessor)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _contextAccessor = contextAccessor;

            baseUri = $"{_contextAccessor.HttpContext?.Request.Scheme}://{_contextAccessor.HttpContext?.Request.Host}";
        }

        public async Task<List<Book>?> GetBooks()
        {
            string requestUri = $"{baseUri}/api/library/getbooks";

            try
            {
                HttpClient httpClient = CreateHttpClient();
                var response = await httpClient.GetAsync(requestUri);

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

        public async Task DeleteBook(Book book)
        {
            string requestUri = $"{baseUri}/api/library/deletebook";

            try
            {
                HttpClient httpClient = CreateHttpClient();
                var json = JsonConvert.SerializeObject(book);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(requestUri, content);

                if (response.IsSuccessStatusCode)
                {
                    return;
                }
                else
                {
                    throw new HttpRequestException($"Failed to delete book. Status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to delete book.", ex);
            }
        }

        public async Task AddBook(Book book)
        {
            string requestUri = $"{baseUri}/api/library/addbook";

            try
            {
                HttpClient httpClient = CreateHttpClient();
                var json = JsonConvert.SerializeObject(book);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(requestUri, content);

                if (response.IsSuccessStatusCode)
                {
                    return;
                }
                else
                {
                    throw new HttpRequestException($"Failed to add book. Status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to add book.", ex);
            }
        }

        public async Task UpdateBook(Book book)
        {
            string requestUri = $"{baseUri}/api/library/updatebook";

            try
            {
                HttpClient httpClient = CreateHttpClient();
                var json = JsonConvert.SerializeObject(book);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(requestUri, content);

                if (response.IsSuccessStatusCode)
                {
                    return;
                }
                else
                {
                    throw new HttpRequestException($"Failed to update book. Status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to update book.", ex);
            }
        }

        public async Task CheckoutBook(Book book)
        {
            string requestUri = $"{baseUri}/api/library/checkoutbook";
            try
            {
                HttpClient httpClient = CreateHttpClient();

                var json = JsonConvert.SerializeObject(book);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(requestUri, content);

                if (response.IsSuccessStatusCode)
                {
                    return;
                }
                else
                {
                    throw new HttpRequestException($"Failed to checkout book. Status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to checkout book.", ex);
            }
        }

        public async Task CheckInBook(Book book)
        {
            string requestUri = $"{baseUri}/api/library/checkinbook";

            try
            {
                HttpClient httpClient = CreateHttpClient();

                var json = JsonConvert.SerializeObject(book);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(requestUri, content);

                if (response.IsSuccessStatusCode)
                {
                    return;
                }
                else
                {
                    throw new HttpRequestException($"Failed to check in book. Status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to check in book.", ex);
            }
        }

        private HttpClient CreateHttpClient()
        {
            HttpClient httpClient = _httpClientFactory.CreateClient();
            var token = _contextAccessor.HttpContext?.Request.Cookies[".AspNetCore.Identity.Application"];
            httpClient.DefaultRequestHeaders.Add("Cookie", $".AspNetCore.Identity.Application={token}");
            return httpClient;
        }
    }
}


