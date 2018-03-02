<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="product.aspx.cs" Inherits="product" Title="Untitled Page" %>

<%@ Register Src="Controls/ProductClass.ascx" TagName="ProductClass" TagPrefix="uc1" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
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
    <td width="703" align="center"><table width="100%" height="29" border="0" cellpadding="0" cellspacing="0" background="images/b2.gif">
      <tr>
        <td style="text-indent:10px;" align="left"><a href="Default.aspx">首页</a> &gt; <a href="Product.aspx">产品中心</a> &nbsp;<asp:Label ID="ClassName" runat="server"></asp:Label></td>
      </tr>
    </table>
        <asp:DataList ID="List_Product" runat="server" HorizontalAlign="Center" RepeatColumns="3" RepeatDirection="Horizontal" CellSpacing="10">
            <ItemTemplate>
              <table width="218" border="0" align="center" cellpadding="5" cellspacing="0">
              <tr>
                <td height="171" align="center" background="images/bk.jpg"><a href="List.aspx?ID=<%#Eval("ID") %>" target="_blank"><img src="UploadFiles/<%#Eval("Pic") %>" alt="<%#Eval("Pro_Name") %>" width="200" height="153" border="0" class="biankuang" /></a></td>
              </tr>
              <tr>
                <td height="30" align="center"><a href="List.aspx?ID=<%#Eval("ID") %>" target="_blank" class="ablue14"><%#Eval("Pro_Name") %></a></td>
              </tr>
              
          </table>
            </ItemTemplate>
        </asp:DataList>
      <table width="100%" height="25" border="0" cellpadding="0" cellspacing="0">
        <tr>
          <td align="center" background="images/b2.gif" bgcolor="#FFFFFF">
              <webdiyer:AspNetPager ID="AspNetPager1" OnPageChanged="AspNetPager1_PageChanged" runat="server" AlwaysShow="True" PageSize="6" UrlPaging="True" FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PageIndexBoxType="TextBox" PrevPageText="上一页" ShowPageIndexBox="Never"></webdiyer:AspNetPager>  
          </td>
        </tr>
      </table>              
          </td>
  </tr>
</table>
</asp:Content>

