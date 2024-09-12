using LibraryManagementSystemUAZ.Data.Data;
using LibraryManagementSystemUAZ.Data.Entities;
using LibraryManagementSystemUAZ.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemUAZ.Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly LibraryContext _context;
        public CategoryRepository(LibraryContext context) : base(context)
        {
            _context = context;
        }

    }
}
