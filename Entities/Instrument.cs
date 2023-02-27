using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTest.Entities
{
    public class Instrument
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Member> Members = new List<Member>();
        
    }
}