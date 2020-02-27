<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Lista de videos</title>
</head>
<body>
    <h1>  Mi lista</h1>
    <p>Hay<%:((System.Data.DataTable)ViewData["datavideo"]).Rows.Count %> videos </p> 
    <br />
    <% foreach (System.Data.DataRow ren in ((System.Data.DataTable)ViewData["datavideo"]).Rows)
    {%>
    <p><%: ren["titulo"].ToString() %> </p> 
    <iframe width="560" height="315" src= "<%: ren["url"].ToString() %>" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture; picture-in-picture" allowfulscreen></iframe>
    <% }%> 
</body>
</html>
