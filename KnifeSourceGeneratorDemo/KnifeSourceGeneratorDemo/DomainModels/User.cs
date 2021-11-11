using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnifeSourceGeneratorDemo.DomainModels
{
    public class User : BaseAggregateRoot
    {
        public string Name { get; set; }
        public string Tel { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }

        public List<Address> AddressDtos { get; set; }
    }
}
