<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 1000px;
            border: 2px solid #000000;
        }
        .style2
        {
            height: 23px;
        }
        .style3
        {
            width: 511px;
        }
        .style4
        {
            height: 23px;
            width: 511px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <strong style="font-size: x-large">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    Car Maintain company&nbsp;</strong><br />
        <br />
    
        <table class="style1" align="center">
            
            <tr>
                <td class="style3">
                    car id :-</td>
                <td>
                    <asp:TextBox ID="txtcid" runat="server"></asp:TextBox>
&nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    car name :-</td>
                <td>
                    <asp:TextBox ID="txtcnm" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    company name: -</td>
                <td class="style2">
                    <asp:TextBox ID="txtcom" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    color :-</td>
                <td class="style2">
                    <asp:TextBox ID="txtcolor" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    price :-</td>
                <td>
                    <asp:TextBox ID="txtprice" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="Large" 
                        Text="Insert" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Font-Bold="True" Font-Size="Large" 
                        Text="Update" />
                    <br />
                    <br />
                    <asp:Button ID="Button3" runat="server" Font-Bold="True" Font-Size="Large" 
                        Text="Delete" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button4" runat="server" Font-Bold="True" Font-Size="Large" 
                        Text="Display" />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:HyperLink ID="HyperLink1" runat="server" Font-Size="Large" 
                        NavigateUrl="~/Report.aspx">Report</asp:HyperLink>
                </td>
            </tr>
        </table>
    
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
