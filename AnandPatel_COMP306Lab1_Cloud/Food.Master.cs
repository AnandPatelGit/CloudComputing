using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnandPatel_COMP306Lab1_Cloud
{
    public partial class Food : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://storage.googleapis.com/anand_restaurant/Menu.pdf");
        }
    }
}