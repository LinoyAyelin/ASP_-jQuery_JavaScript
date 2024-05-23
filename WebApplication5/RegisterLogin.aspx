﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterLogin.aspx.cs" Inherits="WebApplication5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style>
        body{
          direction: rtl;
        height: 100%;
        overflow: hidden;
        color: white;
        background-image: url(data:image/jpeg;base64,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);
        background-repeat: no-repeat;
        background-size: cover;
        }
    </style>
</head>
<body runat="server">
    <form id="form1" runat="server" dir="rtl"  >
        <div>
            <h1>ברוך הבא לאתר המשחקים</h1>
            <h2 runat="server" id="h2"></h2>
        
           
        </div>
        <div style="border:dotted ; width:min-content">
        <table > 
            <tr>
                <td> שם משתמש: </td>
                <td> <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> </td>

            </tr>
            <tr>
                <td>סיסמה:</td>
                <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox> </td >

            </tr>
            </table>
        <asp:Button ID="Button1" runat="server" Text="כניסת משתמשים רשומים" OnClick="Button1_Click"  />
      </div>
        <br />
        <div style="border:dotted ; width:min-content">
            <table>
                <tr>
                    <td>שם מלא: </td>
                    <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td>שם משתמש רצוי:  </td>
                    <td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td>אימייל:  </td>
                    <td><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td>סיסמה רצויה:  </td>
                    <td><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td>חזור על הסיסמה: </td>
                    <td> <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox> </td>
                </tr>
            </table>
            <asp:Button ID="Button2" runat="server"  Text="רישום למשתמש חדש" OnClick="Button2_Click1" />
 
        </div>
        <br />
    
        <input type="button" onclick="window.location.href='topPlayers.html'" value="הצג שחקנים" />
  </form>

</body>
</html>
