using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _10082022_1
{
    public partial class uyeler1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string p1, p2;
            p1 = Request.QueryString["prm1"];
            p2 = Request.QueryString["prm2"];
            //Response.Write("İlk parametre: " + p1);
            //Response.Write("<br>İkinci parametre: " + p2);
            bool cevap=uyemi(p1, p2);
            if (cevap)
            {
                Response.Write("Hoşgeldiniz");
            }
            else
            {
                Response.Redirect("giris.aspx");
            }
        }
        public bool uyemi(string kadi, string sfr)
        {
            bool cevap;
            if ((kadi == "ertev") && (sfr == "1234"))
            {
                cevap = true;
            }
            else
            {
                cevap = false;
            }
            return cevap;
        }
    }
}