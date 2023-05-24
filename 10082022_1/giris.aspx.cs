using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _10082022_1
{
    public partial class giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //SAYFALAR ARASINDA PARAMETRE TAŞIMA
            Response.Redirect("uyeler1.aspx?prm1="+TextBox1.Text+"&prm2="+TextBox2.Text);
        }
    }
}