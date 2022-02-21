using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Football_Field
{
    class userreg
    {
        public int Customer_Password { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Surname { get; set; }
        public string Customer_Phone { get; set; }
        public string Customer_Address { get; set; }
        public string Customers_HB { get; set; }

        public void uuserreg(int Pass, string name, string surr, string ph, string add, string hb)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-A78BTSK\SQLEXPRESS;Initial Catalog=EmployeeMyOwn;Integrated Security=True");
            
            string query = "INSERT INTO registration (Customer_Name, Customer_Surname, Customer_Phone, Customer_Address, Customer_Password, Customers_HB) VALUES (@Pass, @name, @surr, @ph, @add, @hb)";
            
            Con.Open();
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();

            Con.Close();


        }
        

    }
}
