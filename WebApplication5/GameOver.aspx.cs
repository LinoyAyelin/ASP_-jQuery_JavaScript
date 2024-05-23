using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class GameOver : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string imsg = Request.Params["msg"];
            if (imsg != null)
            {
                Msg.InnerText = imsg;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("TicTac.aspx");
        }
    }
}