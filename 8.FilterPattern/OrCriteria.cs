using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.FilterPattern
{
    public class OrCriteria:ICriteria
    {
        ICriteria criteria;
        ICriteria otherCriteria;

        public OrCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            this.criteria = criteria ?? throw new ArgumentNullException(nameof(criteria));
            this.otherCriteria = otherCriteria ?? throw new ArgumentNullException(nameof(otherCriteria));
        }

        public List<Person> meetCriteria(List<Person> Persons)
        {
            List<Person> firstCriteriaItems = criteria.meetCriteria(Persons);
            List<Person> otherCriteriaItems = otherCriteria.meetCriteria(Persons);

            foreach (var person in otherCriteriaItems)
            {
                if (!firstCriteriaItems.Contains(person))
                    firstCriteriaItems.Add(person);
            }
            return firstCriteriaItems;
        }
    }
}
