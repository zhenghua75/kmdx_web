<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="List.aspx.cs" Inherits="List" Title="Untitled Page" %>

<%@ Register Src="Controls/ProductClass.ascx" TagName="ProductClass" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table width="874" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td width="156" align="center" valign="baseline" background="images/b1.gif"><img src="images/pro.gif" width="134" height="58" /></td>
    <td width="718"><img src="images/ban.gif" width="720" height="170" /></td>
  </tr>
</table>
<table width="874" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td width="153" valign="top" bgcolor="#FAFAFA"><table width="154" height="33" border="0" cellpadding="0" cellspacing="0">
      <tr>
        <td background="images/b3.gif" style="text-indent:30px;"><a href="#" class="txt14 chu">产品中心</a></td>
      </tr>
    </table>
        <uc1:ProductClass ID="ProductClass1" runat="server" />
    </td>
    <td width="18">&nbsp;</td>
    <td width="703"><table width="100%" height="29" border="0" cellpadding="0" cellspacing="0" background="images/b2.gif">
      <tr>
        <td style="text-indent:10px;"><a href="Default.aspx">首页</a> &gt; <a href="product.aspx">产品中心</a> 
            <asp:Label ID="ClassName" runat="server"></asp:Label>&nbsp;
            <asp:Label ID="Pro_Name1" runat="server"></asp:Label></td>
      </tr>
    </table>
      <table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
          <td>&nbsp;</td>
        </tr>
      </table>
      <table width="100%" border="0" cellpadding="0" cellspacing="3" class="xu">
        <tbody>
          <tr>
            <td valign="center" class="cp_bian" style="width: 26%"><div align="center">
              <table width="300" border="0" cellspacing="0" cellpadding="0" style=" margin:10px;">
                <tr>
                  <td align="center" style="height: 110px">
                      <asp:Image ID="Image1" runat="server" Height="153px" Width="200px" /><a title="" 
                  href="http://www.i180.cn/pro/shop9/" 
                  target="_blank"></a></td>
                </tr>
              </table>
              <a title="" 
                  href="http://www.i180.cn/pro/shop9/" 
                  target="_blank"></a></div></td>
            <td style="width: 1%">&nbsp;</td>
            <td valign="top" width="73%"><table cellspacing="3" cellpadding="2" width="100%" border="0">
              <tbody>
                <tr>
                  <td><span class="blue12px">名称：<asp:Label ID="Pro_Name" runat="server" Text="Label"></asp:Label></span><span class="txt_blue14"></span></td>
                </tr>
                <tr>
                  <td><span class="blue12px"></span></td>
                </tr>
                <tr>
                  <td class="td_txt">
                      <asp:Label ID="Content" runat="server"></asp:Label></td>
                </tr>
              </tbody>
            </table></td>
          </tr>
          <tr>
            <td background="" colspan="3" height="8"></td>
          </tr>
        </tbody>
      </table>
      </td>
  </tr>
</table>
</asp:Content>

