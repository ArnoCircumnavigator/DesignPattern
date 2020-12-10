using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.FilterPattern
{
    public class CriterialFemale : ICriteria
    {
        public List<Person> meetCriteria(List<Person> Persons)
        {
            return Persons.Where(p => p.GetGender() == "FEMALE").ToList();
        }
    }
}
