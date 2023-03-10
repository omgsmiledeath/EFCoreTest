using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTest.Entities
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Instrument> Instruments { get; set; } = new List<Instrument>();
        public int Age { get; set; }
        public virtual ICollection<Group> Groups { get; set; } = new List<Group>();
    }
}