<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ImageViewer.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Myndaskoðari Vegagerðarinnar</title>
    <style type="text/css">
        .Content{
            padding:1em;
        }
        .Title{
            font-size:xx-large;
            padding-bottom:1em;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="Content">
        <div class="Title">
           <asp:Label ID="Title_Label" runat="server" ></asp:Label>
        </div>
        <div class="Image">
            <img id="chart_img" src="images/chart.png" runat="server"/>
         </div>

    </div>
    </form>
</body>
</html>
