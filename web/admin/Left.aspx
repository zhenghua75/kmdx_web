﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Left.aspx.cs" Inherits="admin_Left" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>后台管理</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <script language="JavaScript" type="text/JavaScript">
    function showsubmenu(sid,sum)
    {
    whichEl = eval("submenu" + sid);
    if (whichEl.style.display == "none")
    {

    for (var i=0;i<=sum;i++)
    {
    if(i==sid)
    eval("submenu" + i + ".style.display=\"\";");
    else
    eval("submenu" + i + ".style.display=\"none\";");
    }
    }
    else
    {
    eval("submenu" + sid + ".style.display=\"none\";");
    }
    }
    </script>
</head>
<body>
    <table width="140" border="0" align="center" cellpadding="1" cellspacing="0">
      <tr>
        <td style="width: 141px">
		    <table width="100%" height="28"  border="0" cellpadding="4" cellspacing="1" bgcolor="#FFFFFF">
		      <tr>
			    <td class="change_td" style="cursor:hand "  onClick="showsubmenu(0,10)"><div align="center"><font class="white">≡ 管理员管理 ≡ </font></div></td>
		      </tr>
		      <tr style="display:none"  id='submenu0'>
		        <td>
				    <table width="98%"  border="0" align="center" cellpadding="0" cellspacing="0">
				      <tr>
					    <td bgcolor="#FFFFFF" height="25"><img src="image/dot_3.jpg" width="12" height="11">&nbsp;&nbsp;<a href="Get_Admin.aspx" target="main" title="管理员管理" class="black_">管理员管理</a></td>
				      </tr>
				      <tr>
					    <td bgcolor="#FFFFFF" height="25"><img src="image/dot_3.jpg" width="12" height="11">&nbsp;&nbsp;<a href="Add_Admin.aspx" target="main" title="添加管理员" class="black_">添加管理员</a></td>
				      </tr>
				    </table>
			    </td>
	          </tr>
		    </table>
		    
		    <table width="100%" height="28"  border="0" cellpadding="4" cellspacing="1" bgcolor="#FFFFFF">
		      <tr>
			    <td class="change_td" style="cursor:hand "  onClick="showsubmenu(1,10)"><div align="center"><font class="white">≡商品管理 ≡ </font></div></td>
		      </tr>
		      <tr style="display:none"  id='submenu1'>
		        <td>
				    <table width="98%"  border="0" align="center" cellpadding="0" cellspacing="0">
				      <tr>
					    <td bgcolor="#FFFFFF" height="25"><img src="image/dot_3.jpg" width="12" height="11">&nbsp;&nbsp;<a href="Get_ProductClass.aspx" target="main" title="商品分类管理" class="black_">商品分类管理</a></td>
				      </tr>
				      <tr>
					    <td bgcolor="#FFFFFF" height="25"><img src="image/dot_3.jpg" width="12" height="11">&nbsp;&nbsp;<a href="Add_ProductClass.aspx" target="main" title="添加商品分类" class="black_">添加商品分类</a></td>
				      </tr>
				       <tr>
					    <td bgcolor="#FFFFFF" height="25"><img src="image/dot_3.jpg" width="12" height="11">&nbsp;&nbsp;<a href="Get_Product.aspx" target="main" title="商品分类管理" class="black_">商品管理</a></td>
				      </tr>
				      <tr>
					    <td bgcolor="#FFFFFF" height="25"><img src="image/dot_3.jpg" width="12" height="11">&nbsp;&nbsp;<a href="Add_Product.aspx" target="main" title="添加商品分类" class="black_">添加商品</a></td>
				      </tr>
				    </table>
			    </td>
	          </tr>
		    </table>
		    
		    <table width="100%" height="28"  border="0" cellpadding="4" cellspacing="1" bgcolor="#FFFFFF">
		      <tr>
			    <td class="change_td" style="cursor:hand "  onClick="showsubmenu(2,10)"><div align="center"><font class="white">≡ 新闻管理 ≡ </font></div></td>
		      </tr>
		      <tr style="display:none"  id='submenu2'>
		        <td>
				    <table width="98%"  border="0" align="center" cellpadding="0" cellspacing="0">
				      <tr>
					    <td bgcolor="#FFFFFF" height="25"><img src="image/dot_3.jpg" width="12" height="11">&nbsp;&nbsp;<a href="Get_NewClass.aspx" target="main" title="新闻分类管理" class="black_">新闻分类管理</a></td>
				      </tr>
				      <tr>
					    <td bgcolor="#FFFFFF" height="25"><img src="image/dot_3.jpg" width="12" height="11">&nbsp;&nbsp;<a href="Add_NewClass.aspx" target="main" title="添加新闻分类" class="black_">添加新闻分类</a></td>
				      </tr>
				      <tr>
					    <td bgcolor="#FFFFFF" height="25"><img src="image/dot_3.jpg" width="12" height="11">&nbsp;&nbsp;<a href="Get_News.aspx" target="main" title="新闻管理" class="black_">新闻管理</a></td>
				      </tr>
				      <tr>
					    <td bgcolor="#FFFFFF" height="25"><img src="image/dot_3.jpg" width="12" height="11">&nbsp;&nbsp;<a href="Add_News.aspx" target="main" title="添加新闻" class="black_">添加新闻</a></td>
				      </tr>
				    </table>
			    </td>
	          </tr>
		    </table>
		    
		    <table width="100%" height="28"  border="0" cellpadding="4" cellspacing="1" bgcolor="#FFFFFF">
		      <tr>
			    <td class="change_td" style="cursor:hand "  onClick="showsubmenu(3,10)"><div align="center"><font class="white">≡ 人才招聘 ≡ </font></div></td>
		      </tr>
		      <tr style="display:none"   id='submenu3'>
		        <td>
				    <table width="98%"  border="0" align="center" cellpadding="0" cellspacing="0">
				      <tr>
					    <td bgcolor="#FFFFFF" height="25"><img src="image/dot_3.jpg" width="12" height="11">&nbsp;&nbsp;<a href="Get_Job.aspx" target="main" title="人才招聘管理" class="black_">人才招聘管理</a></td>
				      </tr>
				      <tr>
					    <td bgcolor="#FFFFFF" height="25"><img src="image/dot_3.jpg" width="12" height="11">&nbsp;&nbsp;<a href="Add_Job.aspx" target="main" title="添加人才招聘" class="black_">添加人才招聘</a></td>
				      </tr>
				    </table>
			    </td>
	          </tr>
		    </table>
		    
		    <table width="100%" height="28"  border="0" cellpadding="4" cellspacing="1" bgcolor="#FFFFFF">
		      <tr>
			    <td class="change_td" style="cursor:hand "  onClick="showsubmenu(4,10)"><div align="center"><font class="white">≡ 系统设置 ≡ </font></div></td>
		      </tr>
		      <tr style="display:none"   id='submenu4'>
		        <td>
				    <table width="98%"  border="0" align="center" cellpadding="0" cellspacing="0">
				      <tr>
					    <td bgcolor="#FFFFFF" height="25"><img src="image/dot_3.jpg" width="12" height="11">&nbsp;&nbsp;<a href="about.aspx" target="main" title="公司简介" class="black_">公司简介</a></td>
				      </tr>
				      <tr>
					    <td bgcolor="#FFFFFF" height="25"><img src="image/dot_3.jpg" width="12" height="11">&nbsp;&nbsp;<a href="Content.aspx" target="main" title="联系我们" class="black_">联系我们</a></td>
				      </tr>
				    </table>
			    </td>
	          </tr>
		    </table>  
	    </td>
      </tr>
      <tr>
        <td height="35" valign="top">
            <table width="100%" height="28"  border="0" cellpadding="4" cellspacing="1" bgcolor="#FFFFFF">
              <tr>
                <td height="28" class="change_td" style="cursor:hand "><div align="center">〓 版权信息 〓</a></td>
              </tr>
              <tr>
                <td><p align="center"><span class="style9">KMDX</span>  <span class="red12px">后台管理</span><br>
                    <a href="http://www.kmdx.cn" class="a_red" target="_blank"><strong><span class="style16">KMDX</span>.cn</strong></a></p> 
                    <a href="http://www.kmdx.cn" target="_blank" title="道迅科技"> www.kmdx.com</a>             </td>
              </tr>
            </table>
        </td>
      </tr>
</table>
</body>
</html>
