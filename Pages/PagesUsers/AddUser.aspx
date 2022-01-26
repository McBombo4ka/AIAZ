<%@ Page Title="Добавление сотрудника лаборатории" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="AI.Pages.PagesUsers.AddUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1><%: Title %></h1>
    <table>
        <tr>
            <td>Выберите должность сотрудника</td>
            <td><asp:DropDownList ID="DropDownListPosition" runat="server"></asp:DropDownList></td>
        </tr>
        <tr> <%--добавить для всех полей таблицы--%>
            <td>ФИО сотрудника</td>
            <td><asp:TextBox ID="TextBoxNameUser" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:HyperLink ID="HyperLinkCancel" NavigateUrl="~/Pages/PagesUsers/ListUsers.aspx" runat="server"> Отмена </asp:HyperLink></td>
            <td><asp:Button ID="ButtonSave" runat="server" Text="Сохранить" OnClick="ButtonSave_Click" /></td>
        </tr>
    </table>
</asp:Content>
