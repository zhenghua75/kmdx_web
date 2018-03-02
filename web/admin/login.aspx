<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="admin_login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>管理员登录</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
    <!--
    body {
	    background-image: url(image/beijing.gif);
	    margin-left: 0px;
	    margin-top: 0px;
	    margin-right: 0px;
	    margin-bottom: 0px;
    }
    .style1 {
	    font-size: 20px;
	    color: #FFFFFF;
	    font-family: "方正综艺简体";
    }
    -->
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table width="1004" height="603" border="0" cellpadding="0" cellspacing="0">   
    <tr>
    <td style="width: 419px"><div align="right"><a href="http://www.kmdx.cn" target="_blank"><img src="image/pic01.gif" width="216" height="301" border="0" ></a></div></td>
    <td valign="top" style="width: 393px"><table width="100%"  border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td width="393" height="151" valign="top">&nbsp;</td>
      </tr>
      <tr>
        <td width="393" height="301" valign="middle" background="image/pic02.gif"><div align="center">
          <table width="100%"  border="0" cellspacing="0" cellpadding="0">
            <tr>
              <td style="height: 30px; width: 182px;"><div align="right" class="unnamed1">&nbsp; 用户名:&nbsp;&nbsp; </div></td>
              <td width="55%" style="height: 30px">              <div align="left">
                  &nbsp;<asp:TextBox ID="UserName" runat="server" CssClass="biaodan" Width="100px"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserName"
                      Display="Dynamic" ErrorMessage="请输入用户名"></asp:RequiredFieldValidator></div></td>
            </tr>
            <tr>
              <td style="width: 182px; height: 19px"><div align="right" class="unnamed1">密&nbsp; 码:&nbsp;&nbsp; </div></td>
              <td style="height: 19px"><div align="left">
                  &nbsp;<asp:TextBox ID="PassWord" runat="server" TextMode="Password" CssClass="biaodan" Width="100px"></asp:TextBox><asp:RequiredFieldValidator
                      ID="RequiredFieldValidator2" runat="server" ControlToValidate="PassWord" Display="Dynamic"
                      ErrorMessage=" 请输入密码"></asp:RequiredFieldValidator></div></td>
            </tr>
            <tr>
              <td height="30" style="width: 182px"><div align="right" class="unnamed1">验证码:&nbsp;&nbsp; </div></td>
              <td height="30" style="text-align: left"><table width="100%"  border="0" cellspacing="0" cellpadding="0">
                <tr>
                  <td style="width: 21%"><div align="left">
                      &nbsp;<asp:TextBox ID="Code" runat="server" Width="40px"></asp:TextBox></div></td>
                  <td width="63%" height="30"><div align="left">
                      &nbsp;<asp:Image ID="ValidateImage" runat="server" Height="20px" Width="53px" ImageAlign="AbsBottom" /></div></td>
                </tr>
              </table>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Code"
                      Display="Dynamic" ErrorMessage="　提示：验证码不能为空"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
              <td height="30" style="width: 182px"><div align="right">
                  <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/admin/image/denglu.gif" OnClick="ImageButton1_Click" />&nbsp;</div></td>
              <td height="30"><div align="left"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                  <asp:Image ID="Image1" runat="server" ImageUrl="~/admin/image/chongzhi.gif" /><a href="#"></a></div></td>
            </tr>
          </table>
          </div></td>
      </tr>
      <tr>
        <td style="height: 19px"></td>
      </tr>
    </table></td>
    <td width="192">&nbsp;</td>
  </tr>
</table>
    </form>
</body>
</html>
