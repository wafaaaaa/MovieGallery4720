using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Role : System.Web.UI.Page
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
        cmd.CommandText = "InsertRole";

        SqlParameter p1 = new SqlParameter();
        SqlParameter p2 = new SqlParameter();
        SqlParameter p3 = new SqlParameter();
        SqlParameter p4 = new SqlParameter();
        SqlParameter p5 = new SqlParameter();

        p1.ParameterName = "@RoleID";
        p2.ParameterName = "@FilmID";
        p3.ParameterName = "@ActorID";
        p4.ParameterName = "@RoleName";
        p5.ParameterName = "@RoleDesc";

        p1.Value = RoleID.Text;
        p2.Value = FilmID.Text;
        p3.Value = ActorID.Text;
        p4.Value = RoleName.Text;
        p5.Value = RoleDesc.Text;

        cmd.Parameters.Add(p1);
        cmd.Parameters.Add(p2);
        cmd.Parameters.Add(p3);
        cmd.Parameters.Add(p4);
        cmd.Parameters.Add(p5);

        cmd.Connection = con;
        cmd.ExecuteNonQuery();
    }
}