using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class Error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string msg = Request.Params["err"];
            if (msg !=null)
            {
                errMsg.InnerText = msg;
            }
        }
    }
}