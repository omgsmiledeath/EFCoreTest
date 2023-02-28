// See https://aka.ms/new-console-template for more information
using EFCoreTest.Context;
using EFCoreTest.Entities;
using System.Linq;
internal class Program
{
    private static void Main(string[] args)
    {
        using (var Context = new GroupBaseContext())
        {
            var drum = new Instrument() { Name = "Vocal" };
            var member1 = new Member()
            {
                Name = "Zobr",
                Age = 29,
                Instruments = new List<Instrument>() { drum },
                Groups = new List<Group>() { Context.Groups.Where(g=>g.Name=="Afterburner").FirstOrDefault() }
            };

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
            
            var zobr = Context.Members.Where(member=>member.Name == "Zobr").Join().Single();
            
            //zobr.Groups.Add(new Group(){Name = "Wimb"});
            //afterband.Members.Add(zobr);
            //Context.SaveChanges();
            System.Console.WriteLine($"{zobr.Name} {zobr.Groups.Count} group");
        }
    }
}

