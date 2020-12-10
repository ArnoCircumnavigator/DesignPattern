using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.FilterPattern
{
    public class AndCriteria:ICriteria
    {
        ICriteria criteria;
        ICriteria otherCriteria;

        public AndCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            this.criteria = criteria ?? throw new ArgumentNullException(nameof(criteria));
            this.otherCriteria = otherCriteria ?? throw new ArgumentNullException(nameof(otherCriteria));
        }

        public List<Person> meetCriteria(List<Person> Persons)
        {
            List<Person> _pensons = criteria.meetCriteria(Persons);
            return otherCriteria.meetCriteria(_pensons);
        }
    }
}
