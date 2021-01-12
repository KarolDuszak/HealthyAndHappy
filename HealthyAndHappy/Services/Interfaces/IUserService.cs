using HealthyAndHappy.Models.ModelsDTO;

namespace HealthyAndHappy.Services.Interfaces
{
    public interface IUserService
    {
        ResponseDTO EditUser(UserDTO userDTO);
        UsersDTO GetAllUsers();
        ResponseAfterAutDTO GetIdAndRoleForUserById(string mail);
    }
}
