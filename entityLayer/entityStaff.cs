using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer
{
    public class entityStaff
    {
        private int staffId;
        private string staffName;
        private string staffSurname;
        private string staffCity;
        private string staffDepartment;
        private short staffSalary;

        public int StaffId { get => staffId; set => staffId = value; }
        public string StaffName { get => staffName; set => staffName = value; }
        public string StaffSurname { get => staffSurname; set => staffSurname = value; }
        public string StaffCity { get => staffCity; set => staffCity = value; }
        public string StaffDepartment { get => staffDepartment; set => staffDepartment = value; }
        public short StaffSalary { get => staffSalary; set => staffSalary = value; }
    }
}
