using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A29.DataAccessObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDao dao = new StudentDao();

            foreach(var t in dao.GetAllStudents())
            {
                Console.WriteLine("Student: [RollNo : "
            + t.rollno+ ", Name : " + t.name+ " ]");
            }


            Student student = dao.GetAllStudents()[0];
            student.name = "张三";
            dao.UpdateStudent(student);

            foreach (var t in dao.GetAllStudents())
            {
                Console.WriteLine("Student: [RollNo : "
            + t.rollno + ", Name : " + t.name + " ]");
            }
        }
    }
}
