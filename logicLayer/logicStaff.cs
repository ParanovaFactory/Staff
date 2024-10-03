using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entityLayer;
using dataAccessLayer;
using System.Runtime.Remoting.Messaging;

namespace logicLayer
{
    public class logicStaff
    {
        public static List<entityStaff> list()
        {
            return DALstaff.staffListing();
        }

        public static int save(entityStaff entity)
        {
            if (entity.StaffName != " " && entity.StaffSurname != " " && entity.StaffDepartment != " " && entity.StaffCity != " " && entity.StaffSalary >= 3500)
            {
                return DALstaff.staffSave(entity);
            }
            else
            {
                return -1;
            }
        }

        public static int delete(entityStaff entity)
        {
            return DALstaff.staffDelete(entity);
        }

        public static int update(entityStaff entity)
        {
            if (entity.StaffName != " " && entity.StaffSurname != " " && entity.StaffDepartment != " " && entity.StaffCity != " " && entity.StaffSalary >= 3500)
            {
                return DALstaff.staffUpdate(entity);
            }
            else
            {
                return -1;
            }
        }

    }
}
