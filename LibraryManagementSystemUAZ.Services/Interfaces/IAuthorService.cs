using LibraryManagementSystemUAZ.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemUAZ.Services.Interfaces
{
    public interface IAuthorService
    {
        Task<Author> GetAuthorByIdAsync(int id);
        Task<IEnumerable<Author>> GetAllAuthorsAsync();
        Task AddAuthorAsync(Author author);
        Task UpdateAuthorAsync(Author author);
        Task DeleteAuthorAsync(int id);
        Task<IEnumerable<Author>> GetAuthorsByBookAsync(int bookId);
        Task<int> CountAsync();
    }
}
