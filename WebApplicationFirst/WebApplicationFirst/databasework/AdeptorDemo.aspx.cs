using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

namespace WebApplicationFirst.databasework
{

    public partial class AdeptorDemo : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //logic to fetch all user and display in gridview
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con=new SqlConnection("server=WALI;database=Cdac;uid=sa;pwd=Waliur#12");
            //DataSet ds= new DataSet();
            DataTable dt = new DataTable();
            string qry = "select * from User_Master";


            SqlDataAdapter adapter = new SqlDataAdapter(qry,con);

            //adapter.Fill(ds);//to get data from database and fill it into dataset
            adapter.Fill(dt);


            //Label1.Text ="total recourd found" +ds.Tables[0].Rows.Count;
            Label1.Text = "total recourd found" + dt.Rows.Count;


            //Response.Write("<br/>userbame:"+ds.Tables[0].Rows[0][1]);

            //binding data with Gridview

            // GridView1.DataSource = ds;
            GridView1.DataSource = dt;

            GridView1.DataBind();
        
        }
    }
}