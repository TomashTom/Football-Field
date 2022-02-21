using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Football_Field
{
    public partial class User_reg : Form
    {
        public User_reg()
        {
            InitializeComponent();
            
        }
        

        private void User_reg_Load(object sender, EventArgs e)
        {
          
        }

        private void back_Click(object sender, EventArgs e)
        {
            registration reg = new registration();
            reg.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void populate()
        {
            
        }
        private void Login_Click(object sender, EventArgs e)
        {
            // new user
            DB db = new DB();
            SqlCommand command = new SqlCommand("INSERT INTO registration (Customer_Name, Customer_Surname, Customer_Phone, Customer_Address, Customer_Password, Customers_HB) VALUES (@cn, @cs, @cp, @ca, @cpass, @chb)", db.GetConnection());
            /*userreg ue = new userreg();*/
            /*ue.uuserreg(Convert.ToInt32(Customer_Password.Text), Customer_Name.Text, Customer_Surname.Text, Customer_Phone.Text, .Text, EmpPhoneTb.Text, EmpEducTb.Text, EmpGenderTb.SelectedItem.ToString());*/
           
            command.Parameters.Add("@cn", SqlDbType.VarChar).Value = Customer_Name.Text;
            command.Parameters.Add("@cs", SqlDbType.VarChar).Value = Customer_Surname.Text;
            command.Parameters.Add("@cp", SqlDbType.VarChar).Value = Customer_Phone.Text;
            command.Parameters.Add("ca", SqlDbType.VarChar).Value = Customer_Address.Text;
            command.Parameters.Add("@cpass", SqlDbType.VarChar).Value = Customer_Password.Text;
            command.Parameters.Add("chb", SqlDbType.VarChar).Value = Customer_HB.Text;
          /*  MessageBox.Show("Added");*/

            // open the connection
            db.openConnection();


            // check if the textboxes contains the defoult values
            if(!checkTextBoxValues())
            {   
                if(Customer_Name.Text.Equals(Customer_Name.Text))
                {
                    // check if the surname/username already exists
                    if (checkUsername())
                    {
                        MessageBox.Show("This already exists, Select a different one", "Dublicate Name or Surname", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {   // execute query
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Your Account has been created", "Account", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Confirmation Surname","Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
               
            else
            {
                MessageBox.Show("Enter your  info first","Emply Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }


            

            



            //close connection
            db.CloseConnection();

            //check if the username alrady exists
           


            
        }
        public Boolean checkUsername()
        {
            DB db = new DB();
            String username = Customer_Surname.Text;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("Select * FROM registration WHERE Customer_Surname = @sur", db.GetConnection());
            command.Parameters.Add("@sur", SqlDbType.VarChar).Value = username;
         
            adapter.SelectCommand = command;
            adapter.Fill(table);
            //check if the user exisc ot not

            if (table.Rows.Count > 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        
        }

        // check if file the textbox contain the default values
        public Boolean checkTextBoxValues()
        {
            String cname = Customer_Name.Text;
            String csuename = Customer_Surname.Text;
            String cphone = Customer_Phone.Text;
            String caddress = Customer_Address.Text;
            String cpass = Customer_Password.Text;
            String chb = Customer_HB.Text;
          
            if (cname.Equals("Customer_Name") || csuename.Equals("Customer_Surname") || cphone.Equals("Customer_Phone")|| caddress.Equals("Customer_Address")|| cpass.Equals("Customer_Password") || chb.Equals("Customers_HB"))
            {
                return true;
            }
           else
            {
                return false;
            }
            
        }
    }
}
