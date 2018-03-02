<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Update_ProductClass.aspx.cs" Inherits="admin_Update_ProductClass" %>

<%@ Register Src="Bottom.ascx" TagName="Bottom" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>修改分类</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <table width="98%"  border="0" cellpadding="3" align="center" cellspacing="0" bgcolor="#F1EAE0">
         <tr>
            <td width="100%" bgcolor="#cccccc" height="5" ></td>
         </tr>
         <tr>
            <td width="100%" class="change_td" style="cursor:hand " >修改商品分类</td>
         </tr>
    </table> 
    <table width="98%"  border="0" align="center" cellpadding="3" cellspacing="1" bgcolor="cccccc">         
		  <tr bgcolor="#eeeeee">
            <td align="right" style="width: 186px; height: 30px;">
                分类名称：&nbsp;</td>
            <td width="80%" style="height: 30px"><asp:TextBox ID="ClassName" runat="server" Width="250px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ClassName"
                    Display="Dynamic" ErrorMessage="分类名称不能为空"></asp:RequiredFieldValidator>
                <asp:HiddenField ID="ClassID" runat="server" />
                <asp:HiddenField ID="ParentID" runat="server" />
            </td>
		  </tr>
          <tr bgcolor="#eeeeee">
            <td align="right" style="width: 186px">&nbsp;</td>
            <td>
                <asp:Button ID="Update_Btn" runat="server"  Text=" 修 改 " OnClick="Update_Btn_Click"  /></td>
          </tr>
    </table>
        <uc1:Bottom ID="Bottom1" runat="server" />
    </form>
</body>
</html>
