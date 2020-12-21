using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A29.DataAccessObjectPattern
{
    /// <summary>
    /// 数据实体，类似于我在Cjia项目中写的Entity
    /// </summary>
    class Student
    {
        public string name;
        public int rollno;

        public Student(string name, int rollno)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.rollno = rollno;
        }
    }
}
