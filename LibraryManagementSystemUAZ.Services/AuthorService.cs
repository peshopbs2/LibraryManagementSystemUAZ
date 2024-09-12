using LibraryManagementSystemUAZ.Data.Entities;
using LibraryManagementSystemUAZ.Data.Interfaces;
using LibraryManagementSystemUAZ.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemUAZ.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AuthorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task AddAuthorAsync(Author author)
        {
            await _unitOfWork.Authors.AddAsync(author);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteAuthorAsync(int id)
        {
            var author = await _unitOfWork.Authors.GetByIdAsync(id);
            if(author != null)
            {
                _unitOfWork.Authors.Delete(author);
                await _unitOfWork.CompleteAsync();
            }
        }

        public async Task<IEnumerable<Author>> GetAllAuthorsAsync()
        {
            return await _unitOfWork.Authors.GetAllAsync();
        }

        public async Task<Author> GetAuthorByIdAsync(int id)
        {
            return await _unitOfWork.Authors.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Author>> GetAuthorsByBookAsync(int bookId)
        {
            return await _unitOfWork.Authors.GetAuthorsByBookAsync(bookId);
        }

        public async Task UpdateAuthorAsync(Author author)
        {
            _unitOfWork.Authors.Update(author);
            await _unitOfWork.CompleteAsync();
        }
    }
}
