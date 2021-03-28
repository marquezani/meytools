<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Zip.aspx.cs" Inherits="Zip.Zip" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Compactar arquivos
        </div>
        <div>
            <asp:FileUpload ID="fupArquivo" runat="server" AllowMultiple="True" />
        &nbsp;</div>
        <div>
            <asp:Button ID="btnCompactarArquivo" runat="server" Text="Compactar" OnClick="btnCompactarArquivo_Click" />
        </div>
    </form>
</body>
</html>
