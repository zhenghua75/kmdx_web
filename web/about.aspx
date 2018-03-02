<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="about.aspx.cs" Inherits="about" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="874" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td width="156" align="center" valign="baseline" background="images/b1.gif"><img src="images/about.gif" width="134" height="58" /></td>
    <td width="718"><img src="images/ban.gif" width="720" height="170" /></td>
  </tr>
</table>
<table width="874" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td width="153" valign="top" bgcolor="#FAFAFA"><table width="154" height="33" border="0" cellpadding="0" cellspacing="0">
      <tr>
        <td background="images/b3.gif" style="text-indent:30px;"><a href="about.aspx" class="txt14 chu">公司简介</a></td>
      </tr>
    </table></td>
    <td width="18">&nbsp;</td>
    <td width="703"><table width="100%" height="29" border="0" cellpadding="0" cellspacing="0" background="images/b2.gif">
      <tr>
        <td style="text-indent:10px; height: 29px;"><a href="Default.aspx">首页</a> &gt; 公司简介</td>
      </tr>
    </table>
      <table width="100%" border="0" cellspacing="0" style="margin:20px;">
        <tr>
          <td class="td_txt"><asp:Label ID="Abouts" runat="server"></asp:Label></td>
        </tr>
      </table></td>
  </tr>
</table>
</asp:Content>

