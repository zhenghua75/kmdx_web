<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="News.aspx.cs" Inherits="News" Title="Untitled Page" %>

<%@ Register Src="Controls/NewClass.ascx" TagName="NewClass" TagPrefix="uc1" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="874" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td width="156" align="center" valign="baseline" background="images/b1.gif"><img src="images/news.gif" width="134" height="58" /></td>
    <td width="718"><img src="images/ban.gif" width="720" height="170" /></td>
  </tr>
</table>
<table width="874" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td width="153" valign="top" bgcolor="#FAFAFA"><table width="154" height="33" border="0" cellpadding="0" cellspacing="0">
      <tr>
        <td background="images/b3.gif" style="text-indent:30px;"><a href="#" class="txt14 chu">新闻中心</a></td>
      </tr>
    </table>
        <uc1:NewClass ID="NewClass1" runat="server" />
    </td>
    <td width="18">&nbsp;</td>
    <td width="703"><table width="100%" height="29" border="0" cellpadding="0" cellspacing="0" background="images/b2.gif">
      <tr>
        <td style="text-indent:10px;">首页 &gt; 新闻中心 
            <asp:Label ID="ClassName" runat="server"></asp:Label>
        </td>
      </tr>
    </table>
        <asp:DataList ID="List_News" runat="server" Width="100%">
            <HeaderTemplate>
                <table width="98%" border="0" align="center" cellpadding="0" cellspacing="0">  
            </HeaderTemplate>
            <ItemTemplate>
                    <tr>
                      <td height="28" align="left" class="cp">·<a href="Article.aspx?ID=<%#Eval("ID") %>" title="<%#Eval("Title") %>" target="_blank"><%#Eval("Title") %></a></td>
                      <td align="center" class="cp" style="width: 182px"><%#Eval("Updatatime")%></td>
                    </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:DataList>
      <table width="100%" height="25" border="0" cellpadding="0" cellspacing="0">
        <tr>
          <td align="center" background="images/b2.gif" bgcolor="#FFFFFF" style="height: 25px">
              <webdiyer:AspNetPager ID="AspNetPager1" OnPageChanged="AspNetPager1_PageChanged" runat="server" FirstPageText="首页" LastPageText="尾页"
                  NextPageText="下一页" PrevPageText="上一页" UrlPaging="True" PageIndexBoxType="TextBox" ShowPageIndexBox="Never" AlwaysShow="True">
              </webdiyer:AspNetPager>
          </td>
        </tr>
      </table></td>
  </tr>
</table>
</asp:Content>