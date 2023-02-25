// See https://aka.ms/new-console-template for more information
using EFCoreTest.Context;
using EFCoreTest.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var Context = new GroupBaseContext())
        {
            var member1 = new Member(){
                Name = "Terrorizer",
                Age = 31,
                Instrument = new Instrument {Name = "Drums"},
                Groups = new List<Group>() {new Group() {Name = "Afterburner"}}
            };
            
            var forDel = Context.Members.Where(mem => mem.Name.Contains("Terr")).ToList();

            Context.Members.RemoveRange(forDel);
            Context.SaveChanges();
        }
    }
}

