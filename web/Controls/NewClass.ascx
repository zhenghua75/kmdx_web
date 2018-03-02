<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NewClass.ascx.cs" Inherits="Controls_NewClass" %>
<asp:Repeater ID="ClassID" runat="server">
    <HeaderTemplate>
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
    </HeaderTemplate>
    <ItemTemplate>
        <tr>
          <td class="cp">· <a href="News.aspx?ClassID=<%#Eval("ClassID") %>"  class="txt14"><%#Eval("ClassName")%></a></td>
        </tr>
    </ItemTemplate>
    <FooterTemplate>
        </table>
    </FooterTemplate>
</asp:Repeater>
