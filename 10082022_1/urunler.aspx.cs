using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _10082022_1
{
    public partial class urunler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uye"] == "ok")
            {
                Response.Write("Bu sayfayı görebilrisin");
            }
            else
            {
                Response.Redirect("index.aspx");
            }
        }
    }
}