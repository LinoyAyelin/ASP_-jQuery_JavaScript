using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            h2.InnerText ="השעה היא " + DateTime.Now.ToString("HH:mm");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string st1 = Request.Params["TextBox1"].ToString();
            string st2 = Request.Params["TextBox2"].ToString();
            if (st1.ToLower() == st2 || st2.ToLower() == st1)
                {
            Response.Redirect("Games.aspx");
            }
            else
            {
                string msg = "שגיאה! שם משתמש או סיסמה לא תואמים";
                Response.Redirect("Error.aspx?err=" + msg, true);
            }
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            string st3 = Request.Params["TextBox3"];
            string st4 = Request.Params["TextBox4"];
            string st5 = Request.Params["TextBox5"];
            string st6 = Request.Params["TextBox6"];
            string st7 = Request.Params["TextBox7"];
            if (string.IsNullOrEmpty(st3)|| string.IsNullOrEmpty(st4) || string.IsNullOrEmpty(st5) || string.IsNullOrEmpty(st6) || string.IsNullOrEmpty(st7))
            {
                string msg = " שגיאה! יש להזין נתונים בכל השדות";
                Response.Redirect("Error.aspx?err=" + msg, true);
            }

            if (st5 != null && !st5.Contains("@"))
            {
                string msg = " שגיאה! האימייל שהקלדת לא כולל את הסימן @";
                Response.Redirect("Error.aspx?err=" + msg, true);
            }
            if (st6 != st7)
            {
                string msg = "שגיאה! הוזנו סיסמאות לא תואמות";
                Response.Redirect("Error.aspx?err=" + msg, true);
            }
            else
            {
                Response.Redirect("Games.aspx");
            }
        }
    }

}