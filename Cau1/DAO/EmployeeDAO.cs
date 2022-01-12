using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.DAO
{
    class EmployeeDAO
    {
        public string IdEmployee { get; set; }
        public string NameEmp { get; set; }
        public string PlaceBirth { get; set; }
        public DateTime DateBirth { get; set; }
        public int Gender { get; set; }
        public DepartmentDAO Department { get; set; }
        public string NameDepartment
        {
            get { return Department.NameDep; }
        }
    }
}
