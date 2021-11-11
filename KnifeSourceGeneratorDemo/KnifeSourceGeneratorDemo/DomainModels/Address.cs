using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnifeSourceGeneratorDemo.DomainModels
{
    public class Address:BaseAggregateRoot
    {
        public string Province { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Details { get; set; }

    }
}
