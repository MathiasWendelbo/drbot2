using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace drbot1
{
    public partial class brn : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
        SqlConnection cann = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
          SqlCommand cmd = new SqlCommand("select * from bruger where brn='" + Session["brn"].ToString() + "'", conn);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            TextBox_brn.Text = reader["brn"].ToString();
            TextBox_pass.Text = reader["pass"].ToString();
            conn.Close();
        }


        protected void Button_opdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update bruger set brn = @brn, pass = @pass where brn='" + Session["brn"].ToString() + "'", cann);

            cmd.Parameters.Add("@brn", SqlDbType.VarChar, 30).Value = TextBox_brn.Text;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar, 20).Value = TextBox_pass.Text;
            int row = 0;
            cann.Open();
            try
            {
                row = cmd.ExecuteNonQuery();
            }

            finally
            {
                if (cann != null)
                    cann.Close();
            }
            Label_opdate.Text = row > 0 ? "fint" : "fejl";

        }
    }
}
