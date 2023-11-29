using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using MVCClientWebAssembly.BookApp.Core;

namespace MyBooksClient.Services
{
    public class BookService
    {
        private readonly HttpClient _httpClient;

        public BookService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync(int pageSize, int pageIndex){
            var response =  await _httpClient.GetFromJsonAsync<BookResponse>($"http://localhost:8080/api/v1/books?size={pageSize}&page={pageIndex}");
            return response.Content.ToList();
        }
    
        public async Task<Book> GetBookByIdAsync(long id)
        {
            return await _httpClient.GetFromJsonAsync<Book>($"http://localhost:8080/api/v1/books/{id}");
        }

        public async Task<Book> AddBookAsync(Book book)
        {
            var response = await _httpClient.PostAsJsonAsync<Book>("http://localhost:8080/api/v1/books", book);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Book>();
            }

            throw new HttpRequestException(
                $"An error occurred while adding a book: {response.ReasonPhrase}"
            );
        }

        public async Task UpdateBookAsync(long id, Book book)
        {
            await _httpClient.PutAsJsonAsync<Book>($"http://localhost:8080/api/v1/books/{id}", book);
        }

        public async Task DeleteBookAsync(long id)
        {
            await _httpClient.DeleteAsync($"http://localhost:8080/api/v1/books/{id}");
        }
    }
}
