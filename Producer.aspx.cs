using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Producer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=cop4720database.database.windows.net;Initial Catalog=ourDatabase;Persist Security Info=True;User ID=wafaa;Password=Database123!");
        SqlCommand cmd = new SqlCommand();
        con.Open();
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.CommandText = "InsertProducer";

        SqlParameter p1 = new SqlParameter();
        SqlParameter p2 = new SqlParameter();
        SqlParameter p3 = new SqlParameter();

        p1.ParameterName = "@ProducerID";
        p2.ParameterName = "@ProducerFirstName";
        p3.ParameterName = "@ProducerLastName";

        p1.Value = ProducerID.Text;
        p2.Value = ProducerFirstName.Text;
        p3.Value = ProducerLastName.Text;

        cmd.Parameters.Add(p1);
        cmd.Parameters.Add(p2);
        cmd.Parameters.Add(p3);

        cmd.Connection = con;
        cmd.ExecuteNonQuery();
    }
}