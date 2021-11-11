using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnifeSourceGeneratorDemo.Models
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public int Age { get; set; }

        public List<AddressDto> AddressDtos { get; set; }
    }
}
