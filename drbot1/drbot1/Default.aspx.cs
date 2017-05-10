using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace drbot1
{
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Button_u.Visible = false;
                Label_m.Visible = false;
                Button_o.Visible = false;
                Label_sv.Visible = false;
                Panel2.Visible = false;
                
            }
        }

        protected void Button_mat_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from drbot where Id='1'", conn);

            conn.Open();
            SqlDataReader re = cmd.ExecuteReader();
            re.Read();
            Label_m.Visible = true;
            Button_u.Visible = true;
            Button_o.Visible = true;
            Button_mwc.Visible = false;
            Button_mat.Visible = false;
            Label_m.Text = re["sp"].ToString();
            Panel1.Visible = false;
            Panel2.Visible = true;
            conn.Close();
        }

        protected void Button_mwc_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("select * from drbot where Id='1'", conn);
            SqlCommand cmd1 = new SqlCommand("select * from svar where Id='1'", conn);
            conn.Open();
            SqlDataReader re = cmd.ExecuteReader();
            re.Read();
            Label_m.Visible = true;
            Button_mwc.Visible = false;
            Button_mat.Visible = false;
            Panel1.Visible = false;
            Label_sv.Visible = true;
            Button_u.Visible = true;
            Button_o.Visible = true;
            Panel2.Visible = true;

            Label_m.Text = re["sp"].ToString();

            conn.Close();
            conn.Open();
            SqlDataReader r = cmd1.ExecuteReader();
            r.Read();
            Label_sv.Text = r["svar"].ToString();
            conn.Close();

        }

        protected void Button_u_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from svar where Id='2'", conn);
            conn.Open();
            SqlDataReader re = cmd.ExecuteReader();
            re.Read();
            Label_sv1.Visible = true;
            Label_sv1.Text = re["svar"].ToString();
            conn.Close();
        }

        protected void Button_o_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("select * from svar where Id='3'", conn);
            conn.Open();
            SqlDataReader re = cmd.ExecuteReader();
            re.Read();
            Label_sv1.Visible = true;
            Label_sv1.Text = re["svar"].ToString();
            conn.Close();
        }
    }
}