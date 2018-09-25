using System;
using System.Web.UI;
using System.Web;

namespace WebPartDemo.VisualWebPart1
{
    public partial class VisualWebPart1UserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
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