using AutoMapper;
using Extrupet.BAL.Interfaces;
using Extrupet.BAL.Models;
using Extrupet.BAL.Utilities;
using Extrupet.DAL.Entity;
using Extrupet.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extrupet.BAL.Services
{
    public class UserService : IUserService
    {
        private readonly UserRepository userDAL;
        private readonly Mapper mapper;

        public UserService()
        {
            userDAL = new UserRepository(new ExtrupetEntities());
            mapper = new MapperProfile().Mapper;
        }

        public IEnumerable<UserGet> GetAllUsers()
        {
            var userRoleMaster = userDAL.GetAllUsers().ToList();
            var userGets = new List<UserGet>();
            foreach (var um in userRoleMaster)
            {
                userGets.Add(mapper.Map<UserGet>(um));
            }

            return userGets;
        }
    }
}
