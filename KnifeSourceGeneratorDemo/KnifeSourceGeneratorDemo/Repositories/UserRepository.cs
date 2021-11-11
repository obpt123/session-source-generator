using KnifeSourceGeneratorDemo.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YS.Knife;

namespace KnifeSourceGeneratorDemo.Repositories
{
    [Service(typeof(UserRepository))]
    public class UserRepository
    {
        public List<User> GetAllUsers()
        {
            return new List<User>
            {
                new User()
                {
                    Id=100001,
                    Age= 12,
                    Name="zhang san",
                    Password="password",
                    Tel="1351234567",
                    CreateBy="system",
                    CreateTime = DateTime.Now,
                    UpdateBy ="user2",
                    UpdateTime = DateTime.Now,
                    AddressDtos =new List<Address> 
                    {
                        new Address 
                        {
                            Id=100002,
                            Province="shannxi",
                            City="xi'an",
                            Street="dazhailu",
                            Details = "details, details",
                            CreateBy="system",
                            CreateTime = DateTime.Now,
                            UpdateBy ="user1",
                            UpdateTime = DateTime.Now,
                        }

                    } 
                }
            };
        }

    }
}
