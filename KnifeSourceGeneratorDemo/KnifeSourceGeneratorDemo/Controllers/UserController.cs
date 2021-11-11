using KnifeSourceGeneratorDemo.Models;
using KnifeSourceGeneratorDemo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YS.Knife;

namespace KnifeSourceGeneratorDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [AutoConstructor]
    public partial class UserController : ControllerBase
    {
        private UserService userService;
        private ILogger<UserController> logger;

        [HttpGet]
        public List<UserDto> GetAllUsers()
            
        {
            //https://docs.microsoft.com/en-us/dotnet/core/extensions/logger-message-generator
            logger.LogInformation("get all users {time}", DateTime.Now);
            return userService.GetAllUsers();
        }
    }
}
