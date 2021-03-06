﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Get_News.aspx.cs" Inherits="admin_Get_News" %>
<%@ Register Src="Bottom.ascx" TagName="Bottom" TagPrefix="uc1" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>新闻管理</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <table width="98%"  border="0" cellpadding="3" align="center" cellspacing="0" bgcolor="#F1EAE0">
             <tr>
                <td width="100%" bgcolor="#cccccc" height="5" ></td>
             </tr>
             <tr>
                <td width="100%" class="change_td" style="cursor:hand " >新闻管理</td>
             </tr>
        </table> 
        <asp:GridView ID="News_List" DataKeyNames="ID" OnRowDeleting="News_List_RowDeleting" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" HorizontalAlign="Center" Width="98%" CellSpacing="1" AutoGenerateColumns="False">
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#EFF3FB" HorizontalAlign="Center" />
            <EditRowStyle BackColor="#2461BF" Font-Italic="True" HorizontalAlign="Center" VerticalAlign="Middle" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <HeaderStyle BackColor="Silver" Font-Bold="True" ForeColor="White" Font-Size="12px" HorizontalAlign="Center" />
            <AlternatingRowStyle BackColor="White" />            
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="Title" HeaderText="新闻标题" />
                <asp:TemplateField HeaderText="新闻分类">                    
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("newClass.ClassName")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="Update_News.aspx?ID={0}"
                    HeaderText="修改" Text="修改" />
                <asp:TemplateField HeaderText="删除">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton2" OnClientClick="return confirm('您确认删除该记录吗?');" runat="server" CommandName="Delete" Font-Names="宋体" Font-Strikeout="False" Font-Underline="False" ForeColor="Black">删除</asp:LinkButton>&nbsp;         
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <div align="center">
        <webdiyer:AspNetPager OnPageChanged="AspNetPager1_PageChanged" ID="AspNetPager1" runat="server" AlwaysShow="True" CustomInfoHTML="第%CurrentPageIndex%页，共%PageCount%页，每页%PageSize%条"
            CustomInfoSectionWidth="20%" CustomInfoTextAlign="Center" FirstPageText="首页"
            LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页"
            UrlPaging="True" Width="98%" Wrap="False" BackColor="ActiveBorder" BorderColor="ActiveCaptionText" Font-Size="12px" Font-Strikeout="False" Font-Underline="False" ForeColor="Black" PageIndexBoxType="TextBox" ShowPageIndexBox="Always" SubmitButtonText="提交" TextAfterPageIndexBox="页" TextBeforePageIndexBox="转到" BorderWidth="1px" PageSize="20">
        </webdiyer:AspNetPager>
            <uc1:Bottom ID="Bottom1" runat="server" />
        </div>
    </form>
</body>
</html>
