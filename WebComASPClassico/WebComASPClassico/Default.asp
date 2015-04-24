<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8"/>
    <title>Página em ASP clássica</title>
</head>
<body>
    <h1>Página em ASP clássica</h1>
    <h2>Características</h2>
    <ul>
        <li>Extensão no formato .asp</li>
        <li>Roda no servidor IIS</li>
        <li>Usa scripts na página através das tag &lt;% e %&gt;</li>
    </ul>
    <%   
        response.Write(now())
        response.Write("<h3>Texto escrito numa página ASP clássica.</h3>")
    %>
</body>
</html>