using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCClientWebAssembly.BookApp.Core;

namespace MVCClientWebAssembly.BookApp.Core
{
    public interface IBookService
    {
        Task<List<IEnumerable<Book>>> GetBooksAsync();
        Task<Book> GetBookByIdAsync(int id);
        Task<Book> CreateBookAsync(Book book);
        Task UpdateBookAsync(Book book);
        Task DeleteBookAsync(int id);
    }
}
