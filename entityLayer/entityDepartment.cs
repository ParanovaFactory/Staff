using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer
{
    internal class entityDepartment
    {
        private int departmentId;
        private string departmentName;
        private string departmentDescription;

        public int DepartmentId { get => departmentId; set => departmentId = value; }
        public string DepartmentName { get => departmentName; set => departmentName = value; }
        public string DepartmentDescription { get => departmentDescription; set => departmentDescription = value; }
    }
}
