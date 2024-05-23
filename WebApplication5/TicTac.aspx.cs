using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class TicTac : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Button2.Text == "") // בדיקה שהכפתור ריק
            {
                Button2.Text = "X";
                CheckGameOver();
                Play();
                CheckGameOver();
            }
            
        }

        private void Play()
        {
            if (Button2.Text == "")
            { Button2.Text = "O"; }
            else if (Button3.Text == "")
            { 
                Button3.Text = "O"; 
            }
            else if (Button4.Text == "")
            {
                { Button4.Text = "O"; }
            }
            else if (Button5.Text == "")
            {
                { Button5.Text = "O"; }
            }
            else if (Button6.Text == "")
            { Button6.Text = "O"; }

            else if (Button7.Text == "")
            { Button7.Text = "O"; }

            else if (Button8.Text == "")
            { Button8.Text = "O"; }

            else if (Button9.Text == "")
            { Button9.Text = "O"; }

            else if (Button10.Text == "")
            { Button10.Text = "O"; }

        }

        private void CheckGameOver()
        {
            //בדיקת שורות
            if ((Button2.Text == "X" && Button3.Text == "X" && Button4.Text == "X")
                ||(Button5.Text == "X" && Button6.Text == "X" && Button7.Text == "X")
                ||(Button8.Text == "X" && Button9.Text == "X" && Button10.Text == "X"))
            {
                string msg = "The Game Is Over! Player X WIN!";
                Response.Redirect("GameOver.aspx?msg=" + msg, true);
            }

            if ((Button2.Text == "O" && Button3.Text == "O" && Button4.Text == "O")
                ||(Button5.Text == "O" && Button6.Text == "O" && Button7.Text == "O")
                ||(Button8.Text == "O" && Button9.Text == "O" && Button10.Text == "O"))
            {
                string msg = "The Game Is Over! Player O WIN!";
                Response.Redirect("GameOver.aspx?msg=" + msg, true);
            }

            //בדיקת עמודות
            if ((Button2.Text == "X" && Button5.Text == "X" && Button8.Text == "X")
                ||(Button3.Text == "X" && Button6.Text == "X" && Button9.Text == "X")
                ||(Button4.Text == "X" && Button7.Text == "X" && Button10.Text == "X"))
            {
                string msg = "The Game Is Over! Player X WIN!";
                Response.Redirect("GameOver.aspx?msg=" + msg, true);
            }

            if ((Button2.Text == "O" && Button5.Text == "O" && Button8.Text == "O")
                || (Button3.Text == "O" && Button6.Text == "O" && Button9.Text == "O")
                || (Button4.Text == "O" && Button7.Text == "O" && Button10.Text == "O"))
            {
                string msg = "The Game Is Over! Player O WIN!";
                Response.Redirect("GameOver.aspx?msg=" + msg, true);
            }

            //בדיקת אלכסונים
            if ((Button2.Text == "X" && Button6.Text == "X" && Button10.Text == "X")
                ||(Button4.Text == "X"&& Button6.Text == "X"&& Button8.Text == "X"))
            {
                string msg = "The Game Is Over! Player X WIN!";
                Response.Redirect("GameOver.aspx?msg=" + msg, true);
            }
            if ((Button2.Text == "O" && Button6.Text == "O" && Button10.Text == "O")
                || (Button4.Text == "O" && Button6.Text == "O" && Button8.Text == "O"))
            {
                string msg = "The Game Is Over! Player O WIN!";
                Response.Redirect("GameOver.aspx?msg=" + msg, true);
            }
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("TicTac.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Button3.Text == "") // בדיקה שהכפתור ריק
            {
                Button3.Text = "X";
                CheckGameOver();
                Play();
                CheckGameOver();
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (Button4.Text == "") // בדיקה שהכפתור ריק
            {
                Button4.Text = "X";
                CheckGameOver();
                Play();
                CheckGameOver();
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (Button5.Text == "") // בדיקה שהכפתור ריק
            {
                Button5.Text = "X";
                CheckGameOver();
                Play();
                CheckGameOver();
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (Button6.Text == "") // בדיקה שהכפתור ריק
            {
                Button6.Text = "X";
                CheckGameOver();
                Play();
                CheckGameOver();
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            if (Button7.Text == "") // בדיקה שהכפתור ריק
            {
                Button7.Text = "X";
                CheckGameOver();
                Play();
                CheckGameOver();
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            if (Button8.Text == "") // בדיקה שהכפתור ריק
            {
                Button8.Text = "X";
                CheckGameOver();
                Play();
                CheckGameOver();
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            if (Button9.Text == "") // בדיקה שהכפתור ריק
            {
                Button9.Text = "X";
                CheckGameOver();
                Play();
                CheckGameOver();
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            if (Button10.Text == "") // בדיקה שהכפתור ריק
            {
                Button10.Text = "X";
                CheckGameOver();
                Play();
                CheckGameOver();
            }
        }
    }
}