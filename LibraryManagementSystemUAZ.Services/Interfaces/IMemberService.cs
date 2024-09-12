using LibraryManagementSystemUAZ.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemUAZ.Services.Interfaces
{
    public interface IMemberService
    {
        Task<Member> GetMemberByIdAsync(int id);
        Task<IEnumerable<Member>> GetAllMembersAsync();
        Task AddMemberAsync(Member member);
        Task UpdateMemberAsync(Member member);
        Task DeleteMemberAsync(int id);
    }
}
