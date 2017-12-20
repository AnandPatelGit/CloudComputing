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
using System.Web.UI.HtmlControls;
using System.IO;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Storage.v1;
using Google.Cloud.Storage.V1;
using Restaurant_App.Data_Layer;

namespace AnandPatel_COMP306Lab1_Cloud
{
    public partial class Order : System.Web.UI.Page
    {
        protected HtmlInputFile fillMyFile;
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
        private ImageUploader _imageUploader;
        protected void Button2_Click(object sender, EventArgs e)
        {
            _imageUploader = new ImageUploader("anand_restaurant");

            string fileName;

            try
            {
                if (fileUploadUser.HasFile)
                {
                    fileName = fileUploadUser.FileName;

                    HttpPostedFile image = fileUploadUser.PostedFile;
    
                    _imageUploader.UploadImage(image, fileName);

                    fileSubmit.Text = "File Uploaded Successfully";
                }
            }
            catch (Exception ex)
            {
                fileSubmit.Text = "File Upload Error";
                //ExceptionLogging.SendExcepToDB(ex);
            }
        }
    }
}