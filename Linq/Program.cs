using System.Linq;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var persons = GetPersons();

            var res = persons.Testing(IsOver20);
            var res2 = persons.Testing(p => p.Age > 20);
            var res3 = persons.Where(p => p.Age > 20);
            var res4 = persons.Where(IsOver20);

            var res5 = persons
                .Where(p => p.Name == "Pelle")
                .Select(p => p.Age)
                .Sum();

            var res6 = persons
                .Where(p => p.Age > 30)
                .Select(p => new PersonDto
                {
                    Name = p.Name,
                    NamesLength = p.Name.Length
                });

            var firstOlle = persons.FirstOrDefault(p => p.Name.Equals("Stina"));

            foreach (var item in res)
            {
                Console.WriteLine(res);
            }

            var p = new Person("Kalle", 10);
            p.AddYear(5);

            Console.WriteLine(p.Age);

            GetPersons().ToList().AddOwnMethod();

            GetPersons().AddOwnMethod2();

            var ints = Enumerable.Range(1, 100).ToArray();

            var r = ints.Testing(i => i > 10);

            Console.ReadLine();

        }

        private static bool IsOver20(Person person)
        {
            return person.Age > 20;
        }

        private static IEnumerable<Person> GetPersons()
        {
            return new List<Person>
                {
                new("Nisse", 20),
                new("Nisse", 21),
                new("Nisse", 22),
                new("Nisse", 23),
                new("Nisse", 24),
                new("Nisse", 24),
                new("Nisse", 26),
                new("Pelle" ,65),
                new("Pelle" ,60),
                new("Pelle" ,62),
                new("Olle" , 66),
                new("Sara" , 54),
                new("Ida" ,  36),
                new("Fia",   45),
                new("Lisa",   45),
                new("Sophia-Magdalena", 10),
            };
        }
    }
}