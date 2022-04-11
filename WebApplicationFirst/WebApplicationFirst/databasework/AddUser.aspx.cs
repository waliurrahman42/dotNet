using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;

namespace WebApplicationFirst.databasework
{
    public partial class AddUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      

        protected void btnSave_Click(object sender, EventArgs e)
        {
            ///SqlConnection con = new SqlConnection("server=WALI;database=Cdac;uid=sa;pwd=Waliur#12");


            string insertQry = "insert into user_master values('" + txtUserName.Text + "','" + txtPassword.Text + "','" + txtName.Text + "'," + txtMobile.Text + ")";

            // SqlCommand cmd = new SqlCommand(insertQry,con);
            //con.Open();


            //int res=cmd.ExecuteNonQuery();

            int res = BusinessLogic.ExecuteQry(insertQry);
            if (res > 0)
            {
                Response.Write("user details saved ");
            }
            //con.Close();
            ClearText();
        }

        void ClearText()
        {
            txtUserName.Text = "";

        }
    }
}