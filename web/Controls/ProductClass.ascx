<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProductClass.ascx.cs" Inherits="Controls_ProductClass" %>
<asp:Repeater ID="ClassID" runat="server">
    <HeaderTemplate>
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
    </HeaderTemplate>
    <ItemTemplate>
        <tr>
          <td class="cp">· <a href="product.aspx?ClassID=<%#Eval("ClassID") %>"  class="txt14"><%#Eval("ClassName")%></a></td>
        </tr>
    </ItemTemplate>
    <FooterTemplate>
        </table>
    </FooterTemplate>
</asp:Repeater>