using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreTest.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Proxies;
namespace EFCoreTest.Context
{
    public class GroupBaseContext:DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Instrument> Instruments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            //optionBuilder.UseSqlite(@"Data Source = /Users/kseniabelaevskaa/Projects/EFCoreTest/EFcoreBase.db;");
            optionBuilder.
            //UseLazyLoadingProxies().
            UseSqlite(@"Data Source = /home/keerah8/Projects/EFCoreTest/EFcoreBase.db");
        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>()
                .HasMany(m => m.Groups).
                WithMany(g => g.Members);
                
            modelBuilder.Entity<Member>().
                HasMany(m => m.Instruments).
                WithMany(i => i.Members);
            
        }
        
    }   
}