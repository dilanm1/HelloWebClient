<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HelloWebClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Sample Web Site</h1>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="First Name: " Width="120px"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Surname: " Width="120px"></asp:Label><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Email: " Width="120px"></asp:Label><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Mobile: " Width="120px"></asp:Label><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />  
         <asp:Label ID="Label6" runat="server" Text="Debt Level: " Width="120px"></asp:Label><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />       
         <asp:Label ID="Label7" runat="server" Text="Monthly Payment: " Width="120px"></asp:Label><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />            
    </div>
        <br /> 
        <br /> 
    <div>
        <asp:Button ID="Button1" runat="server" Text="Submit Data" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>

        <br />
        <asp:Label ID="Label8" runat="server"></asp:Label>

    </div>
        <br /> 
        <br /> 
    <div>
        <h2>Web Lead Table</h2>
        <p>
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="GridView1_PageIndexChanging">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        </p>
    </div>

    </form>
</body>
</html>

