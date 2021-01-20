using AutoMapper;
using HealthyAndHappy.Data;
using HealthyAndHappy.Extensions.Mapper;
using HealthyAndHappy.Models;
using HealthyAndHappy.Models.ModelsDTO;
using HealthyAndHappy.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HealthyAndHappy.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public UserService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public ResponseDTO EditUser(UserDTO userDTO)
        {

            var user = _context.ApplicationUser.Where(b => b.Id == userDTO.Id).SingleOrDefault();
            if (user == null)
            {
                return ResponseDTO.Unsuccessful();
            }
            user.Email = userDTO.Mail;
            user.UserName = userDTO.Name;
            user.PasswordHash = userDTO.Password;

            try
            {
                _context.ApplicationUser.Update(user);
                _context.SaveChanges();

                return ResponseDTO.Successful();

            }
            catch (Exception e)
            {
                return ResponseDTO.Unsuccessful();

            }
            return ResponseDTO.Successful();

        }

        public UsersDTO GetAllUsers()
        {
            var users = _context.ApplicationUser.ToList();
            var userDto = _mapper.Map<UsersDTO>(users);
            return userDto;
        }

        public ResponseAfterAutDTO GetIdAndRoleForUserById(string mail)
        {
            try
            {
                var user = _context.ApplicationUser.Where(u => u.Email == mail).SingleOrDefault();
                return new ResponseAfterAutDTO() { IdUser = user.Id, IsAdmin = user.IsAdmin , Mail = user.Email, Status = ResponseStatus.Successful};
            }
            catch (Exception e)
            {
                return new ResponseAfterAutDTO() { Status = ResponseStatus.Unsuccessful };
            }
            
        }
    }
}
