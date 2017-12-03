using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Actor : System.Web.UI.Page
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
        cmd.CommandText = "InsertActor";

        SqlParameter p1 = new SqlParameter();
        SqlParameter p2 = new SqlParameter();
        SqlParameter p3 = new SqlParameter();

        p1.ParameterName = "@ActorID";
        p2.ParameterName = "@ActorFirstName";
        p3.ParameterName = "@ActorLastName";

        p1.Value = ActorID.Text;
        p2.Value = ActorFirstName.Text;
        p3.Value = ActorLastName.Text;

        cmd.Parameters.Add(p1);
        cmd.Parameters.Add(p2);
        cmd.Parameters.Add(p3);

        cmd.Connection = con;
        cmd.ExecuteNonQuery();
    }
}