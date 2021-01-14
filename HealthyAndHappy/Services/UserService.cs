using AutoMapper;
using HealthyAndHappy.Extensions.Mapper;
using HealthyAndHappy.Models;
using HealthyAndHappy.Models.ModelsDTO;
using HealthyAndHappy.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace HealthyAndHappy.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        public UserService()
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
            _mapper = config.CreateMapper();
        }
        public ResponseDTO EditUser(UserDTO userDTO)
        {
            try
            {
                var user = _mapper.Map<ApplicationUser>(userDTO);
                //dbContext.Set<ApplicationUser>.Update(user);
                return ResponseDTO.Successful();
            }
            catch (Exception e)
            {

                return ResponseDTO.Unsuccessful();
            }  
        }

        public UsersDTO GetAllUsers()
        {
            // get all users
            var users = new List<ApplicationUser>();
            var userDto = _mapper.Map<UsersDTO>(users);
            return userDto;
        }

        public ResponseAfterAutDTO GetIdAndRoleForUserById(string mail)
        {
            try
            {
                //get user from db
                var user = new ApplicationUser();
                return new ResponseAfterAutDTO() { IdUser = user.Id, IsAdmin = user.IsAdmin , Mail = user.Email, Status = ResponseStatus.Successful};
            }
            catch (Exception e)
            {
                return new ResponseAfterAutDTO() { Status = ResponseStatus.Unsuccessful };
            }
            
        }
    }
}
