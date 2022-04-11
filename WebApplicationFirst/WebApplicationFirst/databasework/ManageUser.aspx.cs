using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace WebApplicationFirst.databasework
{
    public partial class ManageUser : System.Web.UI.Page
    {
        
        SqlConnection con = new SqlConnection("server=WALI;database=Cdac;uid=sa;pwd=Waliur#12");
        DataSet ds;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FillGrid();
            }
            if (Request.QueryString["name"] != null)
            {
                Response.Write("walecome:" + Request.QueryString["name"]);
            }
            else
            {
                Server.Transfer("login.aspx");
            }

        }

       

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            //working with parametriz queries
            String searchQry = "select username,fullname,mobile from user_master where user_id=@id";
            
            cmd =new SqlCommand(searchQry,con);

            //bindinfg parameter values
            cmd.Parameters.AddWithValue("@id",txtUserId.Text);

            con.Open();
            //fetching data using DataReader
            reader=cmd.ExecuteReader();


            if (reader.Read())
            {
                //txtUserName.Text = reader[0].ToString();
                //txtName.Text = reader[1].ToString();
                //txtMobile.Text = reader[2].ToString();

                txtUserName.Text = reader.GetString(0);
                txtName.Text = reader.GetString(1);
                txtMobile.Text = reader.GetDecimal(2).ToString();

            }
            else
            {
                Label1.Text = "no record found";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            con.Close();
           


        
        }

        protected async void btnUpdate_Click(object sender, EventArgs e)
        {

            string updateQuery = "update user_master set username=@uname,fullname=@name,mobile=@mobile where user_id=@id";
            //cmd=new SqlCommand(updateQuery,con);

            //cmd.Parameters.AddWithValue("@id", txtUserId.Text)
            //cmd.Parameters.AddWithValue("@uname", txtUserName.Text);
            //cmd.Parameters.AddWithValue("@name", txtName.Text);
            //cmd.Parameters.AddWithValue("@mobile", txtMobile.Text);

            //create sqlParameter array

            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@id", txtUserId.Text),
                new SqlParameter("@uname", txtUserName.Text),
                new SqlParameter("@name", txtName.Text),
                new SqlParameter("@mobile", txtMobile.Text)
            };
            //cmd.Parameters.AddRange(sp);
            //await  con.OpenAsync();//asynchronous open call
            //int res =await cmd.ExecuteNonQueryAsync();///asynchronous ExecuteNonQuery all

            int res =BusinessLogic.ExecuteQry(updateQuery,sp);
            if (res > 0)
            {
                Label1.Text = "user details update sucessfully";
                FillGrid();
            }
           // con.Close();
        }

       
        void FillGrid()
        {
            adapter=new SqlDataAdapter("select user_id ,Username,fullname,Mobile from user_master",con);
            ds= new DataSet();  
            adapter.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

           
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteQuery = "delete from user_master  where user_id=@id";
            cmd = new SqlCommand(deleteQuery, con);

            cmd.Parameters.AddWithValue("@id", txtUserId.Text);

            con.Open();

            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                Response.Write("user deleted ");
            }
            con.Close();
    

        }



        protected void btnViewAll_Click(object sender, EventArgs e)
        {
         FillGrid();
        }
    }
}