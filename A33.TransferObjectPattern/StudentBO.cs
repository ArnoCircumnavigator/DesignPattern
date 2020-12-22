using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A33.TransferObjectPattern
{
    class StudentBO
    {
        List<StudentVO> students;

        public StudentBO()
        {
            students = new List<StudentVO>();
            students.Add(new StudentVO("张三", 1));
            students.Add(new StudentVO("李四", 2));
        }
        public void DeleteStudent(StudentVO student)
        {
            this.students.Remove(student);
            Console.WriteLine("Student: Roll No "
      + student._rollNo + ", deleted from database");
        }
        public List<StudentVO> GetAllStudents()
        {
            return this.students;
        }
        public StudentVO GetStudent(int rollNo)
        {
            return this.students.Where(p => p._rollNo == rollNo).FirstOrDefault();
        }
        public void Update(StudentVO student)
        {
            var t = this.students.Where(p => p._rollNo == student._rollNo).FirstOrDefault();
            if (t != null)//找到了，就更新掉
            {
                t._name = student._name;
            }
            Console.WriteLine("Student: Roll No "
      + student._rollNo + ", updated in the database");
        }
    }
}
