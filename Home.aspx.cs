using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    /* protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
     {

     }*/

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=cop4720database.database.windows.net;Initial Catalog=ourDatabase;Persist Security Info=True;User ID=wafaa;Password=Database123!");
        SqlCommand cmd = new SqlCommand();
        con.Open();
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.CommandText = "InsertMovie";

        SqlParameter p1 = new SqlParameter();
        SqlParameter p2 = new SqlParameter();
        SqlParameter p3 = new SqlParameter();
        SqlParameter p4 = new SqlParameter();
        SqlParameter p5 = new SqlParameter();
        SqlParameter p6 = new SqlParameter();

        p1.ParameterName = "@FilmID";
        p2.ParameterName = "@FilmName";
        p3.ParameterName = "@FilmDesc";
        p4.ParameterName = "@FilmReleaseDate";
        p5.ParameterName = "@CertificationID";
        p6.ParameterName = "@FilmGenreID";

        p1.Value = FilmID.Text;
        p2.Value = FilmName.Text;
        p3.Value = FilmDesc.Text;
        p4.Value = FilmReleaseDate.Text;
        p5.Value = CertificationID.Text;
        p6.Value = FilmGenreID.Text;
        

        cmd.Parameters.Add(p1);
        cmd.Parameters.Add(p2);
        cmd.Parameters.Add(p3);
        cmd.Parameters.Add(p4);
        cmd.Parameters.Add(p5);
        cmd.Parameters.Add(p6);

        cmd.Connection = con;
        cmd.ExecuteNonQuery();

    }
}