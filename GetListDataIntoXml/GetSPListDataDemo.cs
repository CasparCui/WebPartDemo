﻿using System;
using System.IO;
using Microsoft.SharePoint;
using System.Data;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Text;

namespace GetListDataIntoXml
{
    public class GetSPListDataDemo :IDisposable
    {
        private SPSite site = null;
        private SPWeb web = null;
        private SPList list = null;


        public GetSPListDataDemo(string webUrl,string listUrl)
        {
            site = new SPSite(webUrl);
            web = site.OpenWeb();
            list = web.GetList(listUrl);

        }

        private List<string> GetListFieldsNameList()
        {
            List<string> fl = null; 
            
            if(list != null)
            {
                fl = new List<string>();
                foreach(SPField field in list.Fields)
                {
                    fl.Add(field.Title);
                }
            }

            return fl;
        } 

        public XElement GetListData(int itemId)
        {
            var fieldNameList = GetListFieldsNameList();
            if (fieldNameList == null)
                throw new Exception();
            var dataEleList = new List<XElement>();
            var item = list.GetItemById(itemId);

            foreach(var f_Name in fieldNameList)
            {
                var fieldValue = item.GetFormattedValue(f_Name);
                var valueXEle = new XElement(f_Name.Replace(" ","_"), fieldValue);
                dataEleList.Add(valueXEle);
            }

            var itemEle = new XElement(list.Title.Replace(" ", "_"), new XElement(item.Title.Replace(" ", "_"), dataEleList.ToArray()));

            //var ms = new MemoryStream();
            //var buffer = Encoding.UTF8.GetBytes(itemEle.ToString(SaveOptions.DisableFormatting));
            //ms.Write(buffer)
            return itemEle;
            
        }

        #region IDisposable Support
        private bool disposedValue = false; // 要检测冗余调用

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: 释放托管状态(托管对象)。
                }

                // TODO: 释放未托管的资源(未托管的对象)并在以下内容中替代终结器。
                // TODO: 将大型字段设置为 null。

                disposedValue = true;
            }
        }

        // TODO: 仅当以上 Dispose(bool disposing) 拥有用于释放未托管资源的代码时才替代终结器。
        // ~GetSPListDataDemo() {
        //   // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
        //   Dispose(false);
        // }

        // 添加此代码以正确实现可处置模式。
        void IDisposable.Dispose()
        {
            // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
            Dispose(true);
            // TODO: 如果在以上内容中替代了终结器，则取消注释以下行。
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
