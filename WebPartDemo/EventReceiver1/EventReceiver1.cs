using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;

namespace WebPartDemo.EventReceiver1
{
    /// <summary>
    /// 列表项事件
    /// </summary>
    public class EventReceiver1 : SPItemEventReceiver
    {
        /// <summary>
        /// 已添加项.
        /// </summary>
        public override void ItemAdded(SPItemEventProperties properties)
        {
            var item = properties.ListItem;
            item["Title"] = item.Title + "  " + properties.UserDisplayName;
            item.SystemUpdate();
            base.ItemAdded(properties);
            
        }

        /// <summary>
        /// 已向该项添加附件.
        /// </summary>
        public override void ItemAttachmentAdded(SPItemEventProperties properties)
        {
            base.ItemAttachmentAdded(properties);
        }


    }
}