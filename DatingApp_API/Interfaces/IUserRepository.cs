using DatingApp_API.DTOs;
using DatingApp_API.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatingApp_API.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<bool> SaveAllAsync();

        Task<IEnumerable<AppUser>> GetUserAsync();
        Task<AppUser> GetUserByIdAsync(int id);

        Task<AppUser> GetUserByUserNameAsync(string username);
        Task<IEnumerable<MemberDto>> GetMembersAsyns();
        Task<MemberDto> GetMemberAsyns(string username);


    }
}
