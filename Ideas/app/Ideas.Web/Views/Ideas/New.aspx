<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="Ideas.Web.Controllers" %>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">

    <% using(Html.BeginForm<IdeasController>(c => c.Add(null), FormMethod.Post)) { %>
    
        <%= Html.TextBox("Name") %>
        
        <%= Html.TextArea("Text") %>
        
        <%= Html.TextBox("Tags") %>
    
        <%= Html.SubmitButton() %>
    
    <% } %>
   
</asp:Content>
