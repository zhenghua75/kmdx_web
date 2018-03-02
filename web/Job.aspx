<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Job.aspx.cs" Inherits="Job" Title="Untitled Page" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="874" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td align="center" valign="baseline" background="images/b1.gif" style="width: 156px; height: 170px"></td>
    <td width="718" style="height: 170px"><img src="images/ban.gif" width="720" height="170" /></td>
  </tr>
</table>
<table width="874" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td width="153" valign="top" bgcolor="#FAFAFA"><table width="154" height="33" border="0" cellpadding="0" cellspacing="0">
      <tr>
        <td background="images/b3.gif" style="text-indent:30px;"><a href="#" class="txt14 chu">人才招聘</a></td>
      </tr>
    </table>
      </td>
    <td width="18">&nbsp;</td>
    <td width="703"><table width="100%" height="29" border="0" cellpadding="0" cellspacing="0" background="images/b2.gif">
      <tr>
        <td style="text-indent:10px;"><a href="Default.aspx">首页</a> &gt;人才招聘</td>
      </tr>
    </table>
        <asp:DataList ID="List_Job" runat="server" Width="100%">
            <HeaderTemplate>
                <TABLE cellSpacing=0 cellPadding=0 width="98%" align=center border=0>
                   <TBODY>
            </HeaderTemplate>
            <ItemTemplate>                
                     <TR>
                      <TD style="WIDTH: 596px" class="cp"  align=left height=28>·<a href="Job_List.aspx?ID=<%#Eval("ID") %>"  target="_blank"><%#Eval("Title") %></A></TD>
                    <TD  class="cp" align=center width="22%"><%#Eval("Updatatime") %>3</TD>
                    </TR>
                   
                </ItemTemplate>
                <FooterTemplate>
                    </TBODY>
                  </TABLE>
                </FooterTemplate>
        </asp:DataList>
      <table width="100%" height="25" border="0" cellpadding="0" cellspacing="0">
        <tr>
          <td align="center" background="images/b2.gif" bgcolor="#FFFFFF">
              <webdiyer:AspNetPager ID="AspNetPager1" OnPageChanged="AspNetPager1_PageChanged" runat="server" FirstPageText="首页" LastPageText="尾页"
                  NextPageText="下一页" PrevPageText="上一页" UrlPaging="True" PageIndexBoxType="TextBox" ShowPageIndexBox="Never" AlwaysShow="True">
              </webdiyer:AspNetPager>
          </td>
        </tr>
      </table></td>
  </tr>
</table>
</asp:Content>

