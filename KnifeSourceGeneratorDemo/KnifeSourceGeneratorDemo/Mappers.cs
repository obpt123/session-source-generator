using KnifeSourceGeneratorDemo.DomainModels;
using KnifeSourceGeneratorDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnifeSourceGeneratorDemo
{
    [YS.Knife.ConvertTo(typeof(User), typeof(UserDto))]
    public partial class Mappers
    {
    }
}
