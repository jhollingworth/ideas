<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true" Inherits="ViewPage<IdeasViewModel>" %>
<%@ Import Namespace="Ideas.Web.Controllers" %>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
   
    <% foreach (var idea in Model.Ideas) { %>
        <p><%= idea.Name %></p>
        
    <% } %>
   
</asp:Content>
