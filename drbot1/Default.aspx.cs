using System;
using System.Collections.Generic;
using System.Data;
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
                Button_o.Visible = false;
                

                Label_bor_sv.Visible = false;
                Label_s1.Visible = false;
                Label_s.Visible = false;
                Label_svar.Visible = false;
                Label_bor.Visible = false;
                Label_sv.Visible = false;
                Label_bor_sp.Visible = false;
                Label_bor_sv0.Visible = false;
                Panel1.Visible = false;
                Panel2.Visible = false;

            }
        }
        protected void Button_mat_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from drbot where Id='1'", conn);

            conn.Open();
            SqlDataReader re = cmd.ExecuteReader();
            re.Read();
            
            Button_u.Visible = true;
            Button_o.Visible = true;
            Button_mat.Visible = false;
            Button_mwc.Visible = false;
            Literal_sv.Visible = true;
            Label_sv.Visible = true;
            Label_sv.Text = re["sp"].ToString();
            Label_svar.Visible = true;
            Label_svar.Text = Button_mat.Text.ToString();
            conn.Close();
        }

        protected void Button_mwc_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("select * from drbot where Id='1'", conn);
            SqlCommand cmd1 = new SqlCommand("select * from svar where Id='1'", conn);
            conn.Open();
            SqlDataReader re = cmd.ExecuteReader();
            re.Read();
            Button_u.Visible = true;
            Button_o.Visible = true;
            Button_mat.Visible = false;
            Button_mwc.Visible = false;
            Label_svar.Visible = true;
            Label_svar.Text = Button_mwc.Text.ToString();
            Label_svar.Visible = true;
            Literal_sv.Visible = true;
            Label_sv.Visible = true;
            Label_sv.Text = re["sp"].ToString();

            conn.Close();
            conn.Open();
            SqlDataReader r = cmd1.ExecuteReader();
            r.Read();
            Literal_sv.Text = "<div class='sp' style='height:140px;'>" + r["svar"].ToString() + "</div>";
            conn.Close();
        
        }

        protected void Button_u_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from svar where Id='2'", conn);
            conn.Open();
            SqlDataReader re = cmd.ExecuteReader();
            re.Read();

            Label_s.Visible = true;
            Label_s1.Visible = true;
            Label_s1.Text = re["svar"].ToString();
            Label_s.Text = Button_u.Text.ToString();
            conn.Close();
        }

        protected void Button_o_Click(object sender, EventArgs e)
        {
            Button_u.Visible = false;
            Button_o.Visible = false;
            SqlCommand cmd1 = new SqlCommand("select * from drbot where Id='2'", conn);
            conn.Open();
            SqlDataReader r = cmd1.ExecuteReader();
            r.Read();
            Label_bor.Visible = true;
            Label_bor.Text = r["sp"].ToString();
            conn.Close();

            SqlCommand cmd = new SqlCommand("select * from svar where Id='3'", conn);
            conn.Open();
            SqlDataReader re = cmd.ExecuteReader();
            re.Read();
            Label_s.Visible = true;
            Label_s1.Visible = true;
            Label_s1.Text = re["svar"].ToString();
            Label_s.Text = Button_o.Text.ToString();
         
            conn.Close();
            SqlDataAdapter ada = new SqlDataAdapter("select TOP 4 * from svar order by Id DESC", conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            Repeater_landdele.DataSource = dt;
            Repeater_landdele.DataBind(); 
        }

        protected void land(object sender, CommandEventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from svar where Id='" + e.CommandArgument.ToString() +"'", conn);
            conn.Open();
            SqlDataReader re = cmd.ExecuteReader();
            re.Read();
            Label_bor_sv.Visible = true;
            Label_bor_sv0.Visible = true;
            Label_bor_sv.Text = re["land"].ToString();
            Label_bor_sv0.Text = re["svar"].ToString();

            conn.Close();
            Repeater_landdele.Visible = false;
        }

     
    }
}