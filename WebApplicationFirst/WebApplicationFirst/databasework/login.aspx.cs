using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationFirst.databasework
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            Object uname=BusinessLogic.AuthenticateUser(TxtUserName.Text,TxtPassword.Text);
            if (uname != null)
            {
                //passing using querystring
                Response.Redirect("ManageUser.aspx?name="+uname);//local/global both url ,same as sendRediracate() in java
               //Server.Request(); //only to local url , same as forward() in java
               //Server.Execute();//same as include() in java
            }
            else
            {
                lblmsg.Text = "invalid UserName/password!!!";
            }
        
        }
    }
}