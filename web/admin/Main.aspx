<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="admin_Main" %>

<%@ Register Src="Bottom.ascx" TagName="Bottom" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>后台管理</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <table width="98%"  border="0" cellpadding="3" align="center" cellspacing="0" bgcolor="#F1EAE0">
             <tr>
                <td width="100%" bgcolor="#cccccc" height="5" ></td>
             </tr>
             <tr>
                <td width="100%" class="change_td" style="cursor:hand " >服务器参数</td>
             </tr>
        </table> 
    <table cellspacing="1" cellpadding="3" width="98%" align="center"  bgColor="#ffffff" border="0">
          <tbody>
          <tr>
            <td class="th1" align="center" colSpan=2 style="height: 25px">服务器信息统计 </td></tr>
          <tr bgColor="#f9fbf0">
            <td width="50%" style="height: 24px">&nbsp;<strong>服务器名</strong>：<%=System.Environment.MachineName%></td>
            <td width="50%" style="height: 24px">&nbsp;<b>服务器端口：</b><%= HttpContext.Current.Request.ServerVariables["Server_Port"].ToString() %></td></tr>
          <tr bgColor="#f9fbf0">
            <td width="50%" style="height: 23px">&nbsp;<b>脚本解释引擎：</b><%=System.Environment.Version%></td>
            <td width="50%" style="height: 23px"><b>&nbsp;站点物理路径：</b><%=HttpContext.Current.Request.PhysicalApplicationPath.ToString() %></td></tr>
          <tr bgColor="#f9fbf0">
            <td width="50%" style="height: 23px">&nbsp;<b>服务器CPU个数：</b><%=System.Environment.ProcessorCount %> </td>
            <td width="50%" style="height: 23px">&nbsp;<b>服务器IIS版本：</b><%=Request.ServerVariables["SERVER_SOFTWARE"]%></td></tr>
          <tr bgColor="#f9fbf0">
            <td width="50%">&nbsp;<b>开机运行时长</b>：<%=(System.Environment.TickCount/3600000).ToString("N2")%>  小时
            </td>
            <td width="50%"><b>&nbsp;服务器时间：</b><%=DateTime.Now.ToString() %></td></tr>
          <tr bgColor="#f9fbf0">
            <td colspan="2">&nbsp;<b>服务器操作系统：</b><span> <%=System.Environment.OSVersion.ToString()%></span> </td>
            </tr>
              <tr bgcolor="#f9fbf0">
                  <td colspan="2">&nbsp;
                  </td>
              </tr>
          </tbody>
        </table>
        <uc1:Bottom ID="Bottom1" runat="server" />
    </form>
</body>
</html>
