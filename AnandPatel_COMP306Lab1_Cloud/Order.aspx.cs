using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace AnandPatel_COMP306Lab1_Cloud
{
    public partial class Order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonRememberMe_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;

            using (SqlConnection cn = new SqlConnection("[YourConnectionString]"))
            {
                cn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SELECT Count(*) FROM [userEntries] WHERE firstName = @firstName AND password = @lastName";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);

                    try
                    {
                        isPresent = (int)cmd.ExecuteScalar();
                        return isPresent == 1;
                    }
                    catch (SqlException)
                    {
                        throw;
                    }
                }
            }

        }
    }
}