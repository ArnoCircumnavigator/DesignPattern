using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A26.MVCPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Student model_1 = GetSudentFormDataBase();

            StudentView view = new StudentView();

            StudentController controller = new StudentController(model_1,view);

            controller.UpdateView();

            controller.model.Name = "李四";

            controller.UpdateView();
        }
        /// <summary>
        /// 模拟从数据库读出一个学生信息
        /// </summary>
        /// <returns></returns>
        static Student GetSudentFormDataBase()
        {
            Student student = new Student();
            student.Name = "张三";
            student.RollNo = "10";
            return student;
        }
    }
}
