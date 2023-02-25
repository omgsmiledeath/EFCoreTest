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
        public virtual Instrument Instrument { get; set; }
        public int Age { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
    }
}