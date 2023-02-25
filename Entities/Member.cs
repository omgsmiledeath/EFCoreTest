using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTest.Entities
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string InstrumentId { get; set; }
        public int Age { get; set; }
        public ICollection<Group> Groups { get; set; }
    }
}