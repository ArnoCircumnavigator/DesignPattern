using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.FilterPattern
{
    public class Person
    {
        string name;
        string gender;
        string maritalStatus;

        public Person(string name, string gender, string maritalStatus)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.gender = gender ?? throw new ArgumentNullException(nameof(gender));
            this.maritalStatus = maritalStatus ?? throw new ArgumentNullException(nameof(maritalStatus));
        }
        public string GetName()
        {
            return this.name;
        }
        public string GetGender()
        {
            return this.gender;
        }
        public string GetMaritalStatus()
        {
            return this.maritalStatus;
        }
    }
}
