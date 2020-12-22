using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A33.TransferObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentBO studentBusinessObject = new StudentBO();

            foreach(var  t in studentBusinessObject.GetAllStudents())
            {
                Console.WriteLine("Studente: [RollNo : "
         + t._rollNo + ", Name : " + t._name + " ]");
            }

            StudentVO student = studentBusinessObject.GetAllStudents()[0];
            student._name = "小红";
            studentBusinessObject.Update(student);

            foreach (var t in studentBusinessObject.GetAllStudents())
            {
                Console.WriteLine("Studente: [RollNo : "
         + t._rollNo + ", Name : " + t._name + " ]");
            }
        }
    }
}
