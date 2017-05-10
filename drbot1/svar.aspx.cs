using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace drbot1
{
    public partial class svar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_opdate_Click(object sender, EventArgs e)
        {
        /*    SqlCommand cmd = new SqlCommand("update svar set land = @land, svar = @sv where Id='" + DropDownList_valg.SelectedValue + "'", cann);

            cmd.Parameters.Add("@land", SqlDbType.VarChar, 100).Value = TextBox_lando.Text;
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

    */
        }
    }
}