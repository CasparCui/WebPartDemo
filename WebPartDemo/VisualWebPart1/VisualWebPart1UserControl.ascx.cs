using System;
using System.Web.UI;
using System.Web;
using WebServiceDemo1;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Linq;
using System.Web.UI.WebControls.WebParts;
using System.Linq;

namespace WebPartDemo.VisualWebPart1
{
    public partial class VisualWebPart1UserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                var dc = new SharePointLinqDataContext(SPContext.Current.Web.Url);
                var items = dc.GetList<Item>("test List");
                var dataFromLinq = from item in items
                                   where item.Title == "fff"
                                   select new
                                   {
                                       Title = item.Title, ID= item.Id, Path = item.Path
                                   };
                foreach(var node in dataFromLinq)
                {
                    var s = node.ID;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Label1.Visible == false)
            {
                Label1.Visible = true;
                Label1.Text = "Test Button Click";
            }
            else
            {
                Label1.Visible = false;
                Label1.Text = string.Empty;
            }
        }


    }
}