using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataAccessLayer
{
    public class SQLConnection
    {
        public static SqlConnection connection = new SqlConnection(@"Data Source=PREDATOR;Initial Catalog=Staff;Integrated Security=True;TrustServerCertificate=True");
    }
}
