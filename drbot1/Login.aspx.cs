using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;


namespace drbot1
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_login_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from bruger where brn='" + TextBox_brn.Text + "' and pass ='" + TextBox_pass.Text + "'", conn);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                Session["brn"] = reader["brn"].ToString();
                Response.Redirect("brn.aspx?brn=" + reader["brn"].ToString());
            }
            else
            {
                Label_login.Text = "prøv igen";
            }
        }
    }
}