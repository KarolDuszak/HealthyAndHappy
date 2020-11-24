using HealthyAndHappy.Models.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAndHappy.Services.Interfaces
{
    interface IUserService
    {
        ResponseDTO EditUser(UserDTO userDTO);
        UsersDTO GetAllUsers();
        ResponseAfterAutDTO GetIdAndRoleForUserById(string mail);
    }
}
