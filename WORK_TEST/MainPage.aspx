<%@ Page Title="MainPage" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="WORK_TEST.MainPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Fruit WebSite"></asp:Label>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
         <Columns>
            <asp:BoundField DataField="name" HeaderText="Name" />             
                <asp:TemplateField HeaderText="Photo">
                     <ItemTemplate>
                    <asp:Image runat="server" ImageUrl='<%# Eval("photo") %>' ></asp:Image>
                          </ItemTemplate>
                </asp:TemplateField>               
        </Columns>


    </asp:GridView>

    <asp:Button ID="Button1" runat="server" Text="Addfruit" OnClick="btnNewEntry_Click"/>
    



</asp:Content>
