using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Football_Field
{
    public class populate
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpAdd { get; set; }
        public string EmpPos { get; set; }
        public string EmpDob { get; set; }
        public string EmpPhone { get; set; }
        public string EmpEdu { get; set; }
        public string EmpGem { get; set; }


        public List<populate> get_all_employee()
        {

            List<populate> li = new List<populate>();
            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-A78BTSK\SQLEXPRESS;Initial Catalog=EmployeeMyOwn;Integrated Security=True");

            string query = "Select * from Employeee";
            Con.Open();
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                populate p = new populate();
                p.EmpID = (int)dr["EmpId"];
                p.EmpName = dr["EmpName"].ToString();
                p.EmpAdd = dr["EmpAdd"].ToString();
                p.EmpPos = dr["EmpPos"].ToString();
                p.EmpDob = dr["EmpDob"].ToString();
                p.EmpPhone = dr["EmpPhone"].ToString();
                p.EmpEdu = dr["EmpEdu"].ToString();
                p.EmpGem = dr["EmpGem"].ToString();

                li.Add(p);

            }


            Con.Close();


            return li;
        }




    }

    public class display
    {
        public int Customer_Password { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Phone { get; set; }
        public string Customer_Address { get; set; }
        public string Customers_HB { get; set; }


        public List<display> get_users()
        {
            List<display> us = new List<display>();
            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-A78BTSK\SQLEXPRESS;Initial Catalog=EmployeeMyOwn;Integrated Security=True");
            string query = "Select * from registration ";
            Con.Open();
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                display u = new display();
                u.Customer_Password = (int)dr["Customer_Password"];
                u.Customer_Name = dr["Customer_Name"].ToString();
                u.Customer_Phone = dr["Customer_Phone"].ToString();
                u.Customer_Address = dr["Customer_Address"].ToString();
                u.Customers_HB = dr["Customers_HB"].ToString();


                us.Add(u);
            }
            Con.Close();
            return us;
        }
    }
    public class resete
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpAdd { get; set; }
        public string EmpPos { get; set; }
        public string EmpDob { get; set; }
        public string EmpPhone { get; set; }
        public string EmpEdu { get; set; }
        public string EmpGem { get; set; }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-A78BTSK\SQLEXPRESS;Initial Catalog=EmployeeMyOwn;Integrated Security=True");

    }


}
        

        
    
