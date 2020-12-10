using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.FilterPattern
{
    public interface ICriteria
    {
        List<Person> meetCriteria(List<Person> Persons);
    }
}
