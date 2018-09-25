<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="VisualWebPart1UserControl.ascx.cs" Inherits="WebPartDemo.VisualWebPart1.VisualWebPart1UserControl" %>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>s&nbsp;
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=WIN-2D10C362GIE;Initial Catalog=Hwcui_WSS_Content_13SP1_2K;Uid=sa;Pwd=1qaz2wsxE" SelectCommand="SELECT [Id], [SiteId], [DirName], [LeafName], [Level] FROM [AllDocs]"></asp:SqlDataSource>
</p>
<asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SPSqlDataSource1">
    <AlternatingRowStyle BackColor="White" />
    <EditRowStyle BackColor="#2461BF" />
    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#EFF3FB" />
    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#F5F7FB" />
    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
    <SortedDescendingCellStyle BackColor="#E9EBEF" />
    <SortedDescendingHeaderStyle BackColor="#4870BE" />
</asp:GridView>

<SharePoint:SPSqlDataSource ID="SPSqlDataSource1" runat="server" AllowIntegratedSecurity="False" CacheDuration="Infinite" CacheExpirationPolicy="Absolute" CacheKeyDependency="" CancelSelectOnNullParameter="True" ConflictDetection="OverwriteChanges" ConnectionString="Data Source=WIN-2D10C362GIE;Initial Catalog=Hwcui_WSS_Content_13SP1_2K;Uid=sa;Pwd=1qaz2wsxE" DataSourceMode="DataSet" DeleteCommand="" DeleteCommandType="Text" EnableCaching="False" FilterExpression="" InsertCommand="" InsertCommandType="Text" OldValuesParameterFormatString="{0}" ProviderName="" SelectCommand="SELECT [Id], [SiteId], [LeafName], [Level] FROM [AllDocs]" SelectCommandType="Text" SortParameterName="" SqlCacheDependency="" UpdateCommand="" UpdateCommandType="Text">
</SharePoint:SPSqlDataSource>


