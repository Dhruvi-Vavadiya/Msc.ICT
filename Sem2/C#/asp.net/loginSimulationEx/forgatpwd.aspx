<%@ Page Language="VB" AutoEventWireup="false" CodeFile="forgatpwd.aspx.vb" Inherits="forgatpwd" %>

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
                User Name :-
                <asp:TextBox ID="txtunm" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="Button1" runat="server" Text="Submit" />
                &nbsp;<asp:Label ID="lblmsg1" runat="server"></asp:Label>
            </asp:View>
            <asp:View ID="View2" runat="server">
                User Name :-
                <asp:Label ID="lbluser" runat="server"></asp:Label>
                <br />
                <asp:Label ID="lblques" runat="server"></asp:Label>
                &nbsp;
                <asp:TextBox ID="txtans" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="btnget" runat="server" Text="Get" />
                <asp:Label ID="lblmsg2" runat="server"></asp:Label>
            </asp:View>
            <asp:View ID="View3" runat="server">
                Your Password :-<asp:Label ID="lblpwd" runat="server"></asp:Label>
                <br />
                <asp:Button ID="btncontiune" runat="server" Text="Continue" />
            </asp:View>
        </asp:MultiView>
    
    </div>
    </form>
</body>
</html>
