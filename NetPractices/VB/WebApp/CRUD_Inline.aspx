<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CRUD_Inline.aspx.vb" Inherits="WebApp.CRUD_Inline" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inline CRUD</title>
    <style type="text/css">
        td a {
            padding: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h4>Inline CRUD</h4>
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
        <br />
        <asp:GridView ID="gvSubDetails" DataKeyNames="ID" runat="server" AutoGenerateColumns="false"
            ShowFooter="true" OnRowEditing="gvSubDetails_RowEditing" OnRowCommand="gvSubDetails_RowCommand"
            OnRowDeleting="gvSubDetails_RowDeleting" OnRowUpdating="gvSubDetails_RowUpdating"
            OnRowCancelingEdit="gvSubDetails_RowCancelingEdit">
            <HeaderStyle BackColor="#9a9a9a" ForeColor="White" Font-Bold="true" Height="30" />
            <AlternatingRowStyle BackColor="#f5f5f5" />
            <Columns>
                <asp:TemplateField>
                    <EditItemTemplate>
                        <asp:LinkButton ID="lbtnUpdate" runat="server" CommandName="Update" Text="Update" />
                        <asp:LinkButton ID="lbtnCancel" runat="server" CommandName="Cancel" Text="Cancel" />
                    </EditItemTemplate>

                    <ItemTemplate>
                        <asp:LinkButton ID="lbtnEdit" runat="server" CommandName="Edit" Text="Edit" />
                        <asp:LinkButton ID="lbtnDelete" runat="server" CommandName="Delete" Text="Delete"
                            OnClientClick="return confirm('Are you sure you want to delete this record?')"
                            CausesValidation="false" />
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:LinkButton ID="lbtnAdd" runat="server" CommandName="Add" Text="Add New" ValidationGroup="vgAdd" />
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="FirstName">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtFirstName" runat="server" Text='<%#Eval("FirstName").ToString.Trim %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblFirstName" runat="server" Text='<%#Eval("FirstName").ToString.Trim %>' />
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="newFirstName" runat="server" />
                        <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ControlToValidate="newFirstName" Text="*" ForeColor="Red" ValidationGroup="vgAdd" />
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="LastName">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtLastName" runat="server" Text='<%#Eval("LastName").ToString.Trim %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblLastName" runat="server" Text='<%#Eval("LastName") %>' />
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="newLastName" runat="server" />
                        <asp:RequiredFieldValidator ID="rfvLastName" runat="server" ControlToValidate="newLastName" Text="*" ForeColor="Red" ValidationGroup="vgAdd" />
                        <%-- <asp:RegularExpressionValidator ID="revLastName" runat="server" ControlToValidate="newLastName" ValidationExpression="^[0-9]*$" Text="*Numbers" ForeColor="Red" ValidationGroup="vgAdd" /> --%>
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Age">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtAge" runat="server" Text='<%#Eval("Age").ToString.Trim %>' />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblAge" runat="server" Text='<%#Eval("Age").ToString.Trim %>' />
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="newAge" runat="server" />
                        <asp:RequiredFieldValidator ID="rfvAge" runat="server" ControlToValidate="newAge" Text="*" ForeColor="Red" ValidationGroup="vgAdd" />
                    </FooterTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>