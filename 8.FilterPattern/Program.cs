using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.FilterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            persons.Add(new Person("1", "MALE", "Single"));
            persons.Add(new Person("2", "FEMALE", "MARRIED"));
            persons.Add(new Person("3", "FEMALE", "Single"));
            persons.Add(new Person("4", "MALE", "MARRIED"));

            //男性
            ICriteria MALE = new CriteriaMale();
            Console.WriteLine("MALE");
            PrintPersons(MALE.meetCriteria(persons));
            Console.WriteLine();

            //女性
            ICriteria FEMALE = new CriterialFemale();
            Console.WriteLine("FEMALE");
            PrintPersons(FEMALE.meetCriteria(persons));
            Console.WriteLine();

            //单身男性
            ICriteria SingleMale = new AndCriteria(new CriteralSingle(), new CriteriaMale());
            Console.WriteLine("SingleMale");
            PrintPersons(SingleMale.meetCriteria(persons));
            Console.WriteLine();

            //单身的 ，或者是女性
            ICriteria SingleOrFEMale = new OrCriteria(new CriteralSingle(), new CriterialFemale());
            Console.WriteLine("SingleOrFEMale");
            PrintPersons(SingleOrFEMale.meetCriteria(persons));
            Console.WriteLine();


            Console.ReadLine();
        }
        static void PrintPersons(List<Person> persons)
        {
            foreach (var t in persons)
            {
                Console.WriteLine("Person : [ name : "+t.GetName()
                    +", Gender : "+t.GetGender()
                    +", MaritalStatus : "+t.GetMaritalStatus()
                    +"]");
            }
        }
    }
}
