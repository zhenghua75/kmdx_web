<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Update_Admin.aspx.cs" Inherits="admin_Update_Admin" %>

<%@ Register Src="Bottom.ascx" TagName="Bottom" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>修改管理员</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <table width="98%"  border="0" cellpadding="3" align="center" cellspacing="0" bgcolor="#F1EAE0">
         <tr>
            <td width="100%" bgcolor="#cccccc" height="5" ></td>
         </tr>
         <tr>
            <td width="100%" class="change_td" style="cursor:hand " >修改员管理</td>
         </tr>
    </table> 
    <table width="98%"  border="0" align="center" cellpadding="3" cellspacing="1" bgcolor="cccccc">         
		  <tr bgcolor="#eeeeee">
            <td width="20%" align="right">后台登录名称:&nbsp;</td>
            <td width="80%">
                <asp:TextBox ID="UserName" runat="server" ReadOnly="True"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserName"
                    ErrorMessage="后台登录名称不能为空"></asp:RequiredFieldValidator>
                <asp:HiddenField ID="ID" runat="server" />
                <asp:HiddenField ID="LastLoginIP" runat="server" />
                <asp:HiddenField ID="LastLoginTime" runat="server" />
            </td>
		  </tr>
          <tr bgcolor="#eeeeee">
            <td align="right">后台登录密码：&nbsp;</td>
            <td>
                <asp:TextBox ID="Password" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Password"
                    ErrorMessage="后台登录密码不能为空"></asp:RequiredFieldValidator>&nbsp;</td>
          </tr>
          <tr bgcolor="#eeeeee">
            <td align="right">&nbsp;</td>
            <td>
                <asp:Button ID="UpdateBtn" runat="server"  Text="修 改 " OnClick="UpdateBtn_Click" /></td>
          </tr>
</table>
        <uc1:Bottom ID="Bottom1" runat="server" />
    </form>
</body>
</html>
