using LibraryManagementSystemUAZ.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemUAZ.Services.Interfaces
{
    public interface IBookService
    {
        Task<Book> GetBookByIdAsync(int id);
        Task<IEnumerable<Book>> GetAllBooksAsync();
        Task AddBookAsync(Book book);
        Task UpdateBookAsync(Book book);
        Task DeleteBookAsync(int id);
        Task<IEnumerable<Book>> GetBooksByAuthorAsync(int authorId);
        Task<int> CountAsync();
    }
}
