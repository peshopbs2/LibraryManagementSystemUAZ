using LibraryManagementSystemUAZ.Data.Interfaces;
using LibraryManagementSystemUAZ.Data.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemUAZ.Data.Repositories
{
    public class Repository<T> : IRepository<T>
        where T : class
    {
        private readonly LibraryContext _context;
        private readonly DbSet<T> dbSet;
        public Repository(LibraryContext context)
        {
            _context = context;
            dbSet = _context.Set<T>();
        }
        public async Task AddAsync(T entity)
        {
            await dbSet.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
        }
    }
}
