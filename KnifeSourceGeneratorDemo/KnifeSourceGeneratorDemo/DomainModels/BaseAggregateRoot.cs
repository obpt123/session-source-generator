using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnifeSourceGeneratorDemo.DomainModels
{
    public class BaseAggregateRoot
    {
        public int Id { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateTime { get; set; }

        public string UpdateBy { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
