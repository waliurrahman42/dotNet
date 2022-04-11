using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;




using System.Data;//for connnection enum
using System.Data.SqlClient;

namespace WebApplicationFirst.databasework
{
    

    public partial class WebForm1 : System.Web.UI.Page
    {
        
        
        static SqlConnection con;
        String connectionString = "server=WALI;database=Cdac;uid=sa;pwd=Waliur#12";



        //Page_PreInit //object creation
        //Page_Init    //object properties initilization
        //Page_Load
        //Page_Reander
        //Page_Unload





        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("<b>preinit called</b>");
        }


        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("<b>init called</b>");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<b>Page_Load called</b></br>");

            if (!Page.IsPostBack) {
                Response.Write("inside if Page_Load ");
                con = new SqlConnection(connectionString);
            }

        }



       
        //connect with database
        protected void Button1_Click(object sender, EventArgs e)
        {
           

            if(con.State == ConnectionState.Closed)
            {
                con.Open();
                Response.Write("<b>connected with database server successfuly!!!!</b>");
            }
            else
            {
                Response.Write("<b>already conected with database </b>");
            }
                 



        }

        //disconnect from database
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                Response.Write("<b>disconnect from database server successfuly!!!!</b>");
            }
            else
            {
                Response.Write("<b> already disconnect from database server!!!!</b>");
            }

        }

        //status of data base
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                Response.Write("<b>connection is open</b>");
            }
            else
            {
                Response.Write("<b> connection is closed</b>");
            }

        }
    }
}