using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Football_Field
{
   
    public class employs
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpAdd { get; set; }
        public string EmpPos { get; set; }
        public string EmpDob { get; set; }
        public string EmpPhone { get; set; }
        public string EmpEdu { get; set; }
        public string EmpGem { get; set; }


        
        public void reg(int ID, string name, string add, string poss, string dob, string phone, string edu, string gem )
        {
            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-A78BTSK\SQLEXPRESS;Initial Catalog=EmployeeMyOwn;Integrated Security=True");

            string query = "insert into Employeee(EmpID, EmpName,EmpAdd, EmpPos, EmpDob, EmpPhone, EmpEdu, EmpGem) values('" + ID + "','" + name + "','" + add + "','" + poss + "','" + dob + "','" + phone + "','" + edu + "','" + gem + "')";
            Con.Open();
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            
            Con.Close();
        }

        
        }

        
            
    }


