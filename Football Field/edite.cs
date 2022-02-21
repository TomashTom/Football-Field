using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Football_Field
{
    class edite
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpAdd { get; set; }
        public string EmpPos { get; set; }
        public string EmpDob { get; set; }
        public string EmpPhone { get; set; }
        public string EmpEdu { get; set; }
        public string EmpGen { get; set; }
        public void edd(int ID, string name, string add, string poss, string dob, string phone, string edu, string gen)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-A78BTSK\SQLEXPRESS;Initial Catalog=EmployeeMyOwn;Integrated Security=True");

            string query = " Update Employeee set EmpName='" + name + "',EmpAdd='" + add + "',EmpPos='" + poss + "',EmpDob='" + dob + "',EmpPhone='" + phone + "',EmpEdu='" + edu + "',EmpGem='" + gen + "'where EmpId = " + ID + "; ";
            Con.Open();
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();

        }
    }

}

