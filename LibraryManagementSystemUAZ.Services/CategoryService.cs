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
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddCategoryAsync(Category category)
        {
            await _unitOfWork.Categories.AddAsync(category);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteCategoryAsync(int id)
        {
            var category = await _unitOfWork.Categories.GetByIdAsync(id);

            if(category != null)
            {
                _unitOfWork.Categories.Delete(category);
                await _unitOfWork.CompleteAsync();
            }
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await _unitOfWork.Categories.GetAllAsync();
        }

        public async Task<int> CountAsync()
        {
            return await _unitOfWork.Categories.CountAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            return await _unitOfWork.Categories.GetByIdAsync(id);
        }

        public async Task UpdateCategoryAsync(Category category)
        {
            _unitOfWork.Categories.Update(category);
            await _unitOfWork.CompleteAsync();
        }
    }
}
