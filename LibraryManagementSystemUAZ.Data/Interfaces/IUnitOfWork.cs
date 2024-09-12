using LibraryManagementSystemUAZ.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemUAZ.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IBookRepository Books { get; set; }
        public IAuthorRepository Authors { get; set; }
        public ICategoryRepository Categories { get; set; }
        public IMemberRepository Members { get; set; }
        Task<int> CompleteAsync();
    }
}
