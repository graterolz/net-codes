<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CRUD_Simple.aspx.vb" Inherits="WebApp.CRUD_Simple" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simple CRUD</title>
    <style type="text/css">
        td a {
            padding: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h4>Simple CRUD</h4>
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
        <table>
            <tr>
                <td>ID:</td>
                <td><asp:TextBox ID="txtID" runat="server" Enabled="false" /></td>
            </tr>
            <tr>
                <td>First Name:</td>
                <td>
                    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" Text="*" ControlToValidate="txtFirstName" ForeColor="Red" ValidationGroup="vgAdd" />
                </td>
            </tr>
            <tr>
                <td>Last Name:</td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvLastName" runat="server" ControlToValidate="txtLastName" Text="*" ForeColor="Red" ValidationGroup="vgAdd" />                    
                </td>
            </tr>
            <tr>
                <td>Age:</td>
                <td>
                    <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvAge" runat="server" ControlToValidate="txtAge" Text="*" ForeColor="Red" ValidationGroup="vgAdd" />
                    <%-- <asp:RegularExpressionValidator ID="revAge" runat="server" ControlToValidate="txtLastName" ValidationExpression="^[0-9]*$" Text="*Numbers" ForeColor="Red" ValidationGroup="vgAdd" /> --%>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" ValidationGroup="vgAdd" />
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" ValidationGroup="vgAdd" />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" OnClientClick="return confirm('Are you sure you want to delete this record?')" ValidationGroup="vgAdd" />
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" CausesValidation="false" />
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <asp:GridView ID="gvPersonDetails" DataKeyNames="ID" AutoGenerateColumns="false" runat="server" OnSelectedIndexChanged="gvPersonDetails_SelectedIndexChanged" Width="500">
            <HeaderStyle BackColor="#9a9a9a" ForeColor="White" Font-Bold="true" Height="30" />
            <AlternatingRowStyle BackColor="#f5f5f5" />
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lbtnSelect" runat="server" CommandName="Select" Text="Select" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="FirstName">
                    <ItemTemplate>
                        <asp:Label ID="lblFirstName" runat="server" Text='<%#Eval("FirstName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="LastName">
                    <ItemTemplate>
                        <asp:Label ID="lblLastName" runat="server" Text='<%#Eval("LastName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Age">
                    <ItemTemplate>
                        <asp:Label ID="lblAge" runat="server" Text='<%#Eval("Age") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>