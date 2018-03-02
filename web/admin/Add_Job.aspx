<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Add_Job.aspx.cs" Inherits="admin_Add_Job" %>
<%@ Register Src="Bottom.ascx" TagName="Bottom" TagPrefix="uc1" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>添加人才招聘</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <table width="98%"  border="0" cellpadding="3" align="center" cellspacing="0" bgcolor="#F1EAE0">
         <tr>
            <td width="100%" bgcolor="#cccccc" height="5" ></td>
         </tr>
         <tr>
            <td width="100%" class="change_td" style="cursor:hand " >添加商品</td>
         </tr>
    </table> 
    <table width="98%"  border="0" align="center" cellpadding="3" cellspacing="1" bgcolor="cccccc">         
		  <tr bgcolor="#eeeeee">
            <td align="right" style="width: 186px; height: 30px;">
                人才招聘标题：</td>
            <td width="80%" style="height: 30px">
                &nbsp; &nbsp;
                <asp:TextBox ID="Title" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Title"
                    ErrorMessage="标题名称不能为空"></asp:RequiredFieldValidator></td>
		  </tr>
        <tr bgcolor="#eeeeee">
            <td align="right" style="width: 186px; height: 30px">
                访问量：</td>
            <td style="height: 30px" width="80%">
                &nbsp; &nbsp;
                <asp:TextBox ID="Click" runat="server">50</asp:TextBox>
            </td>
        </tr>
        <tr bgcolor="#eeeeee">
            <td align="right" style="width: 186px; height: 30px">
                人才招聘内容：</td>
            <td style="height: 30px" width="80%">
                <fckeditorv2:fckeditor id="Content" runat="server"></fckeditorv2:fckeditor>
            </td>
        </tr>
        <tr bgcolor="#eeeeee">
            <td align="right" style="width: 186px; height: 30px">
            </td>
            <td style="height: 30px" width="80%">
                <asp:Button ID="Add_Btn" runat="server" Text="添加" OnClick="Add_Btn_Click" /></td>
        </tr>
          <tr bgcolor="#eeeeee">
            <td align="right" style="width: 186px">&nbsp;</td>
            <td>
                </td>
          </tr>
    </table>
    <uc1:Bottom ID="Bottom1" runat="server" />
    </form>
</body>
</html>
