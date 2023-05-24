using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _10082022_1
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool gelen;
            gelen=uyemi(TextBox2.Text,TextBox1.Text);
            if (gelen)
            {
                //gerçekten üye(doğru kullanıcı ve şifre girmiş)
                Session["uye"] = "ok";
                Response.Redirect("uyeler.aspx");
            }
            else
            {
                Label2.Text = "Hatalı Kullanıcı Adı yada Şifre";
            }
        }
        public bool uyemi(string kadi,string sfr)
        {
            bool cevap;
            if ((kadi=="ertev")&&(sfr=="1234"))
            {
                cevap=true;
            }
            else
            {
                cevap = false;
            }
            return cevap;
        }
    }
}