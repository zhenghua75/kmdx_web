<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Add_Product.aspx.cs" Inherits="admin_Add_Product" %>

<%@ Register Src="Bottom.ascx" TagName="Bottom" TagPrefix="uc1" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>添加商品</title>
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
                商品名称：</td>
            <td width="80%" style="height: 30px">
                &nbsp; &nbsp;
                <asp:TextBox ID="Pro_Name" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Pro_Name"
                    ErrorMessage="商品名称不能为空"></asp:RequiredFieldValidator></td>
		  </tr>
        <tr bgcolor="#eeeeee">
            <td align="right" style="width: 186px; height: 30px">
                访问量：</td>
            <td style="height: 30px" width="80%">
                &nbsp; &nbsp;
                <asp:TextBox ID="Click" runat="server">50</asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Click"
                    ErrorMessage="访问量不能为空"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Click"
                    ErrorMessage="访问量必须为数字" ValidationExpression="^[0-9]*[1-9][0-9]*$"></asp:RegularExpressionValidator></td>
        </tr>
        <tr bgcolor="#eeeeee">
            <td align="right" style="width: 186px; height: 30px">
                商品图片：
            </td>
            <td style="height: 30px" width="80%">
                &nbsp; &nbsp;&nbsp;
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr bgcolor="#eeeeee">
            <td align="right" style="width: 186px; height: 30px">
                商品分类：</td>
            <td style="height: 30px" width="80%">
                &nbsp; &nbsp;
                <asp:DropDownList ID="ClassID" runat="server">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ClassID"
                    ErrorMessage="商品分类不能为空"></asp:RequiredFieldValidator></td>
        </tr>
        <tr bgcolor="#eeeeee">
            <td align="right" style="width: 186px; height: 30px">
                详细简介：</td>
            <td style="height: 30px" width="80%">
                <fckeditorv2:fckeditor id="Content" runat="server"></fckeditorv2:fckeditor>
            </td>
        </tr>
        <tr bgcolor="#eeeeee">
            <td align="right" style="width: 186px; height: 30px">
            </td>
            <td style="height: 30px" width="80%">
                <asp:Button ID="Add_Btn" runat="server" Text="添加新商品" OnClick="Add_Btn_Click" /></td>
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
