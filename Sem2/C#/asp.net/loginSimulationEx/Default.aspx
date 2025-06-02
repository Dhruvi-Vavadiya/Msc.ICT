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
            width: 315px;
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
                            User Name :-</td>
                        <td>
                            <asp:TextBox ID="txtunm" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="txtunm" ErrorMessage="Must Enter User Name" ForeColor="Red" 
                                SetFocusOnError="True">Pleace Enter User Name</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            Password :-</td>
                        <td>
                            <asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            Confirm Password :-</td>
                        <td>
                            <asp:TextBox ID="txtcpwd" runat="server" TextMode="Password"></asp:TextBox>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                ControlToCompare="txtpwd" ControlToValidate="txtcpwd" 
                                ErrorMessage="Same as Password" ForeColor="#CC0000" SetFocusOnError="True">Complsary Same As Password</asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            Email ID :-</td>
                        <td>
                            <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                ControlToValidate="txtemail" ErrorMessage="Pleace Enter Email ID" 
                                ForeColor="Red" SetFocusOnError="True" 
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Pleace Enter Email ID</asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            Security Questions :-</td>
                        <td>
                            <asp:TextBox ID="txtque" runat="server" TextMode="MultiLine"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style2">
                            Answer :-</td>
                        <td>
                            <asp:TextBox ID="txtans" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="txtans" ErrorMessage="Pleace Enter Answer" ForeColor="Red" 
                                SetFocusOnError="True">Pleace Enter Answer</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                     <tr>
                        <td class="style2">
                            &nbsp;</td>
                        <td>
                            <asp:Button ID="btncreate" runat="server" Text="Create" />
                            <br />
                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                         </td>
                    </tr>
                </table>
            </asp:View>
            <asp:View ID="View2" runat="server">
                User Created Successfully<br />
                <asp:Button ID="Button1" runat="server" Text="Contiune" />
            </asp:View>
        </asp:MultiView>
    
    </div>
    </form>
</body>
</html>
