using KnifeSourceGeneratorDemo.Models;
using KnifeSourceGeneratorDemo.Repositories;
using System.Collections.Generic;
using System.Linq;
using YS.Knife;

namespace KnifeSourceGeneratorDemo.Services
{
    [Service(typeof(UserService))]
    [AutoConstructor]
    public partial class UserService
    {
        UserRepository userRepository;

        public List<UserDto> GetAllUsers()
        {
            return userRepository.GetAllUsers().ToUserDto().ToList();
        }
    }
}
