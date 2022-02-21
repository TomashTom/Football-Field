using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Football_Field
{
    class DB
    {
        private SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-A78BTSK\SQLEXPRESS;Initial Catalog=EmployeeMyOwn;Integrated Security=True");

        public void openConnection()
        {

            if(Con.State  == System.Data.ConnectionState.Closed)
            {
                Con.Open();
            }

        }
        public void CloseConnection()
        {
            if (Con.State == System.Data.ConnectionState.Open)
            {
                Con.Close();
            }

        }
        public SqlConnection GetConnection()
        {
            return Con;
        }

    }
}
