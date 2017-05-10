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
    public partial class Cms : System.Web.UI.MasterPage
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["brn"] == "gaest") Response.Redirect("login.aspx");

            Label_brn.Text = Session["brn"].ToString();

            SqlCommand cmd1 = new SqlCommand("select * from bruger where brn='" + Session["brn"].ToString() + "'", conn);

            conn.Open();
            SqlDataReader re = cmd1.ExecuteReader();
            re.Read();
            int nr = Convert.ToInt32(re["rolle"]);
            conn.Close();

            HyperLink_obrn.Visible = false;
            SqlCommand cmd = new SqlCommand("select * from bruger where rolle=" + nr, conn);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            switch (reader["rolle"].ToString())
            {
                case "1":
                    HyperLink_obrn.Visible = true;
                    break;
                default:
                    break;
            }
            conn.Close();

        }

        protected void Button_log_ud_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session["brn"] = "gaest";
            Response.Redirect("login.aspx");

        }
    }
}