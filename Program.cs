// See https://aka.ms/new-console-template for more information
using EFCoreTest.Context;
using EFCoreTest.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
internal class Program
{
    private static void Main(string[] args)
    {
        using (var Context = new GroupBaseContext())
        {
            

            //Context.Groups.RemoveRange(Context.Groups.Where(g => g.Id < 3).ToList());
            //Context.Instruments.RemoveRange(
            //    Context.Instruments.Where(i=>i.Id <3).ToList()
            //    );
            //Context.Members.Add(member1);
            //Context.Members.Remove(Context.Members.Where(m => m.Id == 3).Single());
            //Context.Members.Remove(Context.Members.Where(m => m.Name.Contains("Terrorizer")).Single());
            // var vrongband = Context.Groups.Where(g=>g.Id==2).SingleOrDefault();
            // if (vrongband!=null) 
            // {
            //     Context.Groups.Remove(vrongband);
            //     Context.SaveChanges();
            // }
            var afterband = Context.Groups.Where(g=>g.Name.Contains("Afterburner")).Single();
            var members = Context.Members.Include(member => member.Groups).ToList();
            var zobr = members.Where(member=>member.Name == "Zobr").Single();
            
            //zobr.Groups.Add(new Group(){Name = "Wimb"});
            //afterband.Members.Add(zobr);
            //Context.SaveChanges();
            System.Console.WriteLine($"{zobr.Name} {zobr.Groups.Count} group");
        }
    }
}

