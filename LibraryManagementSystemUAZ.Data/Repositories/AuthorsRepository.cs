using LibraryManagementSystemUAZ.Data.Data;
using LibraryManagementSystemUAZ.Data.Entities;
using LibraryManagementSystemUAZ.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemUAZ.Data.Repositories
{
    public class AuthorsRepository : Repository<Author>, IAuthorRepository
    {
        private LibraryContext _context;
        public AuthorsRepository(LibraryContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Author>> GetAuthorsByBookAsync(int bookId)
        {
            return await _context.BookAuthors
                .Where(ba => ba.BookId == bookId)
                .Select(ba => ba.Author)
                .ToListAsync();
        }
    }
}
