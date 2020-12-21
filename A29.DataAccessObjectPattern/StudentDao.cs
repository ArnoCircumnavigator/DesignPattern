using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A29.DataAccessObjectPattern
{
    /// <summary>
    /// 实际的操作
    /// 引出一个思考，如果我的配置，有些是xml，有些是数据库，那么我是不是可以
    /// 做一个ConfigerDao？
    /// </summary>
    class StudentDao : IStudentDao
    {
        /// <summary>
        /// 这个就当是数据库了
        /// </summary>
        List<Student> students;

        public StudentDao()
        {
            this.students = new List<Student>();
            Student student1 = new Student("Robert", 0);
            Student student2 = new Student("John", 1);
            students.Add(student1);
            students.Add(student2);
        }

        public void DeleteStudent(Student student)
        {
            students.Remove(student);
            Console.WriteLine("Student: Roll No " + student.rollno
               + ", deleted from database");
        }

        public List<Student> GetAllStudents()
        {
            return this.students;
        }

        public Student GetStudent(int rollno)
        {
            return this.students.Where(p => p.rollno == rollno).FirstOrDefault();
        }

        public void UpdateStudent(Student student)
        {
            //通过主键找到数据库中的那个
            Student t = students.Where(p => p.rollno == student.rollno).FirstOrDefault();
            if(t !=null)
            {
                t.name = student.name;//更新掉
            }
            Console.WriteLine("Student: Roll No " + student.rollno
               + ", updated in the database");
        }
    }
}
