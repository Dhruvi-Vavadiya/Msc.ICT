<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                User Name :-<asp:TextBox ID="txtunm" runat="server"></asp:TextBox>
                <br />
                Password :-<asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <asp:Button ID="btnLogin" runat="server" Text="Login" />
                <asp:Label ID="lblmsg" runat="server"></asp:Label>
                <br />
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/forgatpwd.aspx">Password Recovery</asp:HyperLink>
            </asp:View>
            <asp:View ID="View2" runat="server">
                Welcome&nbsp;&nbsp;<asp:Literal ID="Literal1" runat="server"></asp:Literal>
                &nbsp;
                <asp:LinkButton ID="LinkButton1" runat="server">LogOut</asp:LinkButton>
                <br />
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/changepwd.aspx">Change Password</asp:HyperLink>
            </asp:View>
        </asp:MultiView>
    
    </div>
    </form>
</body>
</html>
