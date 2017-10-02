using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace AnandPatel_COMP306Lab1_Cloud
{
    public partial class Order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonRememberMe_Click(object sender, EventArgs e)
        {
            
            string cs = ConfigurationManager.ConnectionStrings["LocalMySqlServer"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(cs))
            {

                String firstName = textBoxFirstName.Text;
                String lastName = textBoxLastName.Text;

                if (firstName != null && lastName != null)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select count(firstName) from userEntries where firstName='" + firstName + "'and lastName='" + lastName + "'";
                    cmd.Connection = conn;
                    conn.Open();
                    int LoginResult = (int)cmd.ExecuteScalar();
                    if (LoginResult == 1)
                    {
                        cmd.CommandText = "select city,postalCode,phoneNumber,province from userEntries where firstName='" + firstName + "'and lastName='" + lastName + "'";
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            String city = reader.GetString(0);
                            textBoxCity.Text = city;
                            String postalCode = reader.GetString(1);
                            textBoxPostalCode.Text = postalCode;
                            int phoneNumber = reader.GetInt32(2);
                            textBoxPhoneNumber.Text = phoneNumber.ToString();
                            String province = reader.GetString(3);
                            dropDownListProvince.Text = province;  
                        }
                    }
                    conn.Close();
                }
                else
                {
                    Response.Write("Provide input in the fields");
                }
            }
        }
    }
}