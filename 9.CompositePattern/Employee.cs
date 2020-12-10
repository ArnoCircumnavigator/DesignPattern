using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.CompositePattern
{
    public class Employee
    {
        string name;
        string dept;
        int salary;
        //当前雇员手下的人（组成树形结构，以表示组成当前整体的部分）
        List<Employee> subordinates;

        public Employee(string name, string dept, int salary)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.dept = dept ?? throw new ArgumentNullException(nameof(dept));
            this.salary = salary;
            this.subordinates = new List<Employee>();
        }
        public void Add(Employee e)
        {
            this.subordinates.Add(e);
        }
        public void Remove(Employee e)
        {
            this.subordinates.Remove(e);
        }
        public List<Employee> GetSubordinates()
        {
            return this.subordinates;
        }
        public override string ToString()
        {
            return "Employee : [ Name : " + name + ", dept : " + dept + ",salary : " + salary + "]";
        }
    }
}
