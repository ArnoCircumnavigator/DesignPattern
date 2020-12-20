using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A26.MVCPattern
{
    class StudentController
    {
        public Student model;
        public StudentView view;

        public StudentController(Student model, StudentView view)
        {
            this.model = model ?? throw new ArgumentNullException(nameof(model));
            this.view = view ?? throw new ArgumentNullException(nameof(view));
        }
        public void UpdateView()
        {
            view.Print(model.Name, model.RollNo);
        }
    }
}
