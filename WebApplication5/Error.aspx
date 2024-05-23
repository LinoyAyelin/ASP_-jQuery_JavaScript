<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="WebApplication5.Error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
          direction: rtl;
        height: 100%;
        overflow: hidden;
       
background-image: url(https://www.kingcode.co.il/wp-content/uploads/2020/11/404.jpg);

        background-repeat: no-repeat;
        background-size: cover;
        }
    </style>
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 runat="server" id="errMsg"></h1>
        </div>
    </form>
</body>
</html>
