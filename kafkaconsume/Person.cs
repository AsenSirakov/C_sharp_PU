using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kafkaproduce
{
    [MessagePackObject]
    public class Person
    {
        [Key(0)]
        public Guid Id { get; set; }

        [Key(1)]
        public string Name { get; set; }
    }
}
