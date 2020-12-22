using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A33.TransferObjectPattern
{
    class StudentVO
    {
        public string _name;
        public int _rollNo;

        public StudentVO(string name, int rollNo)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _rollNo = rollNo;
        }
    }
}
