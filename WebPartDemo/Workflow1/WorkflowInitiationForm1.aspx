<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Import Namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>

<%@ Page Language="C#" 
    DynamicMasterPageFile="~masterurl/default.master" 
    AutoEventWireup="true" 
    Inherits="WebPartDemo.Workflow1.WorkflowInitiationForm1" 
    CodeBehind="WorkflowInitiationForm1.aspx.cs" %>

<asp:Content ID="Main" ContentPlaceHolderID="PlaceHolderMain" runat="server">
    Write Something: <asp:TextBox ID="TextBox" runat="server"></asp:TextBox>   
     <asp:Button ID="StartWorkflow" runat="server" OnClick="StartWorkflow_Click" Text="启动工作流" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Cancel" runat="server" OnClick="Cancel_Click" Text="取消  " />
</asp:Content>

<asp:Content ID="PageTitle" ContentPlaceHolderID="PlaceHolderPageTitle" runat="server">
    工作流启动窗体
</asp:Content>

<asp:Content ID="PageTitleInTitleArea" runat="server" ContentPlaceHolderID="PlaceHolderPageTitleInTitleArea">
    工作流启动窗体
</asp:Content>
