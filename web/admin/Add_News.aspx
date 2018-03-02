<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Add_News.aspx.cs" Inherits="admin_Add_News" %>
<%@ Register Src="Bottom.ascx" TagName="Bottom" TagPrefix="uc1" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>添加新闻</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <table width="98%"  border="0" cellpadding="3" align="center" cellspacing="0" bgcolor="#F1EAE0">
         <tr>
            <td width="100%" bgcolor="#cccccc" height="5" ></td>
         </tr>
         <tr>
            <td width="100%" class="change_td" style="cursor:hand " >添加新闻</td>
         </tr>
    </table> 
    <table width="98%"  border="0" align="center" cellpadding="3" cellspacing="1" bgcolor="cccccc">         
		  <tr bgcolor="#eeeeee">
            <td width="20%" align="right" style="height: 30px">
                新闻标题：</td>
            <td width="80%" style="height: 30px">
                &nbsp;<asp:TextBox ID="Title" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Title"
                    ErrorMessage="新闻标题不能为空"></asp:RequiredFieldValidator></td>
		  </tr>
          <tr bgcolor="#eeeeee">
            <td align="right">
                来源：&nbsp;</td>
            <td>
                &nbsp;<asp:TextBox ID="Source" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Source"
                    ErrorMessage="来源不能为空"></asp:RequiredFieldValidator></td>
          </tr>
        <tr bgcolor="#eeeeee">
            <td align="right">
                作者：</td>
            <td>
                &nbsp;<asp:TextBox ID="Author" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Author"
                    ErrorMessage="作者不能为空"></asp:RequiredFieldValidator></td>
        </tr>
        <tr bgcolor="#eeeeee">
            <td align="right">
                新闻分类：</td>
            <td>
                <asp:DropDownList ID="ClassID" runat="server">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ClassID"
                    ErrorMessage="新闻分类不能为空"></asp:RequiredFieldValidator></td>
        </tr>
        <tr bgcolor="#eeeeee">
            <td align="right">
                详细内容：</td>
            <td>
                <FCKeditorV2:FCKeditor ID="Content" runat="server">
                </FCKeditorV2:FCKeditor>
            </td>
        </tr>
        <tr bgcolor="#eeeeee">
            <td align="right">
                访问量：</td>
            <td>
                <asp:TextBox ID="Click" runat="server">50</asp:TextBox></td>
        </tr>
          <tr bgcolor="#eeeeee">
            <td align="right">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text=" 添 加 " /></td>
          </tr>
</table>
        <uc1:Bottom ID="Bottom1" runat="server" />
    </form>
</body>
</html>
