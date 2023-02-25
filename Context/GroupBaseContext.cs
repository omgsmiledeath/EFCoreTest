using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreTest.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTest.Context
{
    public class GroupBaseContext:DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Instrument> Instruments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite(@"Data Source = \tmp\EFcoreBase.db;");
        }
    }   
}