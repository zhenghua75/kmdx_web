<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Job_List.aspx.cs" Inherits="Job_List" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="874" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td width="156" align="center" valign="baseline" background="images/b1.gif">
        &nbsp;<img height="58" src="images/job.gif" width="134" /></td>
    <td width="718"><img src="images/ban.gif" width="720" height="170" /></td>
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
        <td style="text-indent:10px;">首页 &gt; 人才招聘&nbsp;
        </td>
      </tr>
    </table>
      <table width="98%" border="0" align="center" cellpadding="6" cellspacing="0">
        <tr>
          <td align="center">&nbsp;</td>
        </tr>
        <tr>
          <td height="30" align="center"><strong class="txt_blue16"><img src="images/icon_education.gif" width="15" height="13" />
              <span class="txt14">
                  <asp:Label ID="Title_2" runat="server"></asp:Label></span></strong></td>
        </tr>
        <tr>
          <td align="center" class="xu_di">[ <span class="td_txt">
              <asp:Label ID="Updatatime" runat="server"></asp:Label></span>]    </td>
        </tr>
        <tr>
          <td align="left" style="height: 16px">
              <asp:Label ID="Content" runat="server"></asp:Label></td>
        </tr>
      </table>
      <br />
      </td>
  </tr>
</table>
</asp:Content>

