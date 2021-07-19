<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="MvcWebFormEx.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Consumir Wweb Services desde ASP.NET</h1>
            
           
            Numero1<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> <br/ />  Numero2<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
           
            <br /><asp:Button ID="Button1" Text="Suma" runat="server" OnClick="Button1_Click" />
           
            <br /> <asp:Button ID="Button2" Text="Resta" runat="server" OnClick="Button2_Click"/>
            
             <br /><asp:Button ID="Button3" Text="Multiplicar" runat="server"  OnClick="Button3_Click"/>
           
            <br /><asp:Button ID="Button4" Text="Dividir" runat="server" OnClick="Button4_Click"/> <br />  <asp:Label ID="Label1" runat="server" Text="Resultado"></asp:Label>    
            
            
        </div>
    </form>
</body>
</html>
