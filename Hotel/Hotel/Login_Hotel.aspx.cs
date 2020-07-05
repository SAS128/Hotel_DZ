using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;

namespace Hotel
{
    public partial class Login_Hotel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Redirect("http://.../about.aspx");

            if (IsPostBack)
            {
                Response.Redirect("WebRegistr.aspx");
            }
        }
    }
}