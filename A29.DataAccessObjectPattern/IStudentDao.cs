using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A29.DataAccessObjectPattern
{
    interface IStudentDao
    {
        List<Student> GetAllStudents();
        Student GetStudent(int rollno);
        void UpdateStudent(Student student);
        void DeleteStudent(Student student);
    }
}
