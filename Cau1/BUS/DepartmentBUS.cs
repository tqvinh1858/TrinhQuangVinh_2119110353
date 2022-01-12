using Cau1.DAL;
using Cau1.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.BUS
{
    class DepartmentBUS
    {
        DepartmentDAL dal = new DepartmentDAL();
        public List<DepartmentDAO> ReadDepartmentList()
        {
            List<DepartmentDAO> lstDepartment = dal.ReadDepartmentList();
            return lstDepartment;
        }
    }
}
