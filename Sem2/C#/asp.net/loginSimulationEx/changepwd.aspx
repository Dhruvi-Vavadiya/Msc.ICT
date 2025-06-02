<%@ Page Language="VB" AutoEventWireup="false" CodeFile="changepwd.aspx.vb" Inherits="changepwd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 1000px;
            border-style: solid;
            border-width: 2px;
        }
        .style2
        {
            width: 416px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                <table class="style1">
                    <tr>
                        <td class="style2">
                            Old Password :-</td>
                        <td>
                            <asp:TextBox ID="txtoldpwd" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            New Password :-</td>
                        <td>
                            <asp:TextBox ID="txtnewpwd" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            confirm Password :-</td>
                        <td>
                            <asp:TextBox ID="txtconpwd" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            &nbsp;</td>
                        <td>
                            <asp:Button ID="Button1" runat="server" Text="Change" />
                        </td>
                    </tr>
                </table>
            </asp:View>
            <asp:View ID="View2" runat="server">
                Password Changed Successfully<br />
                <asp:Button ID="Button2" runat="server" Text="Continue" />
            </asp:View>
        </asp:MultiView>
    
    </div>
    </form>
</body>
</html>
