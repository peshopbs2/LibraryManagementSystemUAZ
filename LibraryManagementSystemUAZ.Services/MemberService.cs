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
    public class MemberService : IMemberService
    {
        private readonly IUnitOfWork _unitOfWork;
        public MemberService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddMemberAsync(Member member)
        {
            await _unitOfWork.Members.AddAsync(member);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteMemberAsync(int id)
        {
            var member = await _unitOfWork.Members.GetByIdAsync(id);
            if (member != null)
            {
                _unitOfWork.Members.Delete(member);
                await _unitOfWork.CompleteAsync();
            }
        }

        public async Task<IEnumerable<Member>> GetAllMembersAsync()
        {
            return await _unitOfWork.Members.GetAllAsync();
        }

        public async Task<Member> GetMemberByIdAsync(int id)
        {
            return await _unitOfWork.Members.GetByIdAsync(id);
        }

        public async Task<int> CountAsync()
        {
            return await _unitOfWork.Members.CountAsync();
        }
        public async Task UpdateMemberAsync(Member member)
        {
            _unitOfWork.Members.Update(member);
            await _unitOfWork.CompleteAsync();
        }
    }
}
