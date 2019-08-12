using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace AdoGridDemo
{
    public partial class DataDisplay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("data source=DESKTOP-KOVOIEV\\SQLEXPRESS;database=TSQL2012;integrated security=SSPI");
            SqlCommand command = new SqlCommand("select * from [TSQL2012].[dbo].[Departments]",conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
            conn.Close();

        }
    }
}