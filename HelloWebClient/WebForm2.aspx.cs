using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace HelloWebClient
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        string connectionString = ConfigurationManager.ConnectionStrings["Genius_ConnectionString"].ConnectionString;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Genius_ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            if (!Page.IsPostBack)
            {
                BindData();
            }
        }
        void BindData()
        {
            try
            {


                conn.Open();
                SqlCommand comm = new SqlCommand("select WebLeadID,Planid,AccountRef,Firstname,Surname,Email,Tel1,DebtLevel,MonthlyPayment,website from cic_HBwebleads Order By WebLeadID DESC ", conn);
                SqlDataAdapter adp = new SqlDataAdapter(comm);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();
                comm.Connection.Close();
                comm.Connection.Dispose();


            }
            catch (Exception ex)
            {
                //ShowMessage(ex.Message);
            }
            finally
            {
                //close the database connection
                conn.Close();
            }

        }
      
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
        }
    }
}