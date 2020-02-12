using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            tiktikEntities d = new tiktikEntities();
            tem t = new tem();
            t.first_name = TextBox1.Text;
            t.age = int.Parse(TextBox2.Text);
            t.login_name = TextBox3.Text;
            t.password = TextBox4.Text;
            t.experience = int.Parse(TextBox8.Text);
            t.salary_exp = int.Parse(TextBox7.Text);
            d.tems.Add(t);
            d.SaveChanges();
        }
    }
}