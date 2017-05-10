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
    public partial class sp : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
        SqlConnection cann = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter ada = new SqlDataAdapter("select * from drbot", conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            GridView_spoerg.DataSource = dt;
            GridView_spoerg.DataBind();

            if (!IsPostBack)
            {
                drop();
                dropslet();
            }
        }
        protected void drop()
        {
            SqlCommand cmd = new SqlCommand("select * from drbot", conn);

            conn.Open();
            try
            {
                ListItem item = new ListItem();
                item.Text = "valg";
                item.Value = "0";
                DropDownList_valg.Items.Add(item);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListItem db = new ListItem();
                    db.Text = reader["sp"].ToString();
                    db.Value = reader["sp"].ToString();
                    DropDownList_valg.Items.Add(db);
                }
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        protected void dropslet()
        {
            SqlCommand cmd = new SqlCommand("select * from drbot", conn);

            conn.Open();
            try
            {
                ListItem item = new ListItem();
                item.Text = "valg";
                item.Value = "0";
                DropDownList_slet.Items.Add(item);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListItem db = new ListItem();
                    db.Text = reader["sp"].ToString();
                    db.Value = reader["sp"].ToString();
                    DropDownList_slet.Items.Add(db);
                }
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }
        protected void DropDownList_valg_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from drbot where sp='" + DropDownList_valg.SelectedValue.ToString() + "'", conn);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            TextBox_osp.Text = reader["sp"].ToString();
            TextBox_osv.Text = reader["sv"].ToString();
            conn.Close();
        }

        protected void Button_opret_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("select TOP 1* from drbot order by Id desc", conn);

            conn.Open();
            SqlDataReader reader = cmd1.ExecuteReader();
            reader.Read();

            int nr = Convert.ToInt32(reader["Id"]);

            conn.Close();

            SqlCommand cmd = new SqlCommand("insert into drbot (sp, sv, Id) values (@sp, @sv, @id)", cann);

            cmd.Parameters.Add("@sp", SqlDbType.VarChar, 100).Value = TextBox_sp.Text;
            cmd.Parameters.Add("@sv", SqlDbType.Text).Value = TextBox_sv.Text;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = nr + 1;
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
            Label_opret.Text = row > 0 ? "fint" : "fejl";
        }

        protected void Button_opdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update drbot set sp = @sp, sv = @sv where sp='" + DropDownList_valg.SelectedValue + "'", cann);

            cmd.Parameters.Add("@sp", SqlDbType.VarChar, 100).Value = TextBox_sp.Text;
            cmd.Parameters.Add("@sv", SqlDbType.Text).Value = TextBox_sv.Text;
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

        protected void Button_slet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from drbot where sp='" + DropDownList_slet.SelectedValue + "'", cann);
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
            Label_slet.Text = row > 0 ? "fint" : "fejl";

        }
    }
}