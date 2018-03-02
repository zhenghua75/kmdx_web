<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Content.aspx.cs" Inherits="admin_Content" %>
<%@ Register Src="Bottom.ascx" TagName="Bottom" TagPrefix="uc1" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>联系我们</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <table width="98%"  border="0" cellpadding="3" align="center" cellspacing="0" bgcolor="#F1EAE0">
         <tr>
            <td width="100%" bgcolor="#cccccc" height="5" ></td>
         </tr>
         <tr>
            <td width="100%" class="change_td" style="cursor:hand " >联系我们</td>
         </tr>
    </table> 
    <table width="98%"  border="0" align="center" cellpadding="3" cellspacing="1" bgcolor="cccccc">         
        <tr bgcolor="#eeeeee">
            <td align="right" style="width: 186px; height: 30px">
                联系我们：</td>
            <td style="height: 30px" width="80%">
                <fckeditorv2:fckeditor id="Contact" runat="server"></fckeditorv2:fckeditor>
            </td>
        </tr>
        <tr bgcolor="#eeeeee">
            <td align="right" style="width: 186px; height: 30px">
            </td>
            <td style="height: 30px" width="80%">
                <asp:Button ID="Update_Btn" runat="server" Text="修改" OnClick="Update_Btn_Click" />
                <asp:HiddenField ID="About" runat="server" />
            </td>
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
