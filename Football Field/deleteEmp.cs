using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Football_Field
{
    class deleteEmp
    {
        public int EmpID { get; set; }
       

        public void delete(int ID)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-A78BTSK\SQLEXPRESS;Initial Catalog=EmployeeMyOwn;Integrated Security=True");
            
            String query = "Delete from Employeee where EmpId='" + ID + "';";
            Con.Open();
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();

        }
    }
}
