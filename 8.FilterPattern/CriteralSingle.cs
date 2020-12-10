using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.FilterPattern
{
    class CriteralSingle : ICriteria
    {
        public List<Person> meetCriteria(List<Person> Persons)
        {
            return Persons.Where(p => p.GetMaritalStatus() == "Single").ToList();
        }
    }
}
