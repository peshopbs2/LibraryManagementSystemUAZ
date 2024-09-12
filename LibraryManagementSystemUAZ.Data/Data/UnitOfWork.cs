using LibraryManagementSystemUAZ.Data.Interfaces;
using LibraryManagementSystemUAZ.Data.Repositories;
using LibraryManagementSystemUAZ.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemUAZ.Data.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LibraryContext _context;
        public UnitOfWork(LibraryContext context)
        {
            _context = context;
            Books = new BookRepository(_context);
            Authors = new AuthorsRepository(_context);
            Categories = new CategoryRepository(_context);
            Members = new MemberRepository(_context);
        }
        public IBookRepository Books { get; set; }
        public IAuthorRepository Authors { get; set; }
        public ICategoryRepository Categories { get; set; }
        public IMemberRepository Members { get; set; }
        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
