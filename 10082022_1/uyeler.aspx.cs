using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _10082022_1
{
    public partial class uyeler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uye"]=="ok")
            {
                Response.Write("Üye doğrulamadan geçmiş");
            }
            else
            {
                Response.Redirect("index.aspx");
            }
        }
    }
}