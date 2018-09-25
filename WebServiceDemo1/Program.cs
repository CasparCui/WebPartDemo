using System;
using System.Xml;
using System.IO;

namespace WebServiceDemo1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SharePointWebService.Lists listService = new SharePointWebService.Lists();
            listService.Credentials = System.Net.CredentialCache.DefaultCredentials;
            var xmlDoc = new XmlDocument();
            var itemQuery = xmlDoc.CreateNode(XmlNodeType.Element, "Query", string.Empty);
            var itemQueryOptions = xmlDoc.CreateNode(XmlNodeType.Element, "QueryOptions", string.Empty);
            var itemViewFields = xmlDoc.CreateNode(XmlNodeType.Element, "ViewFields", string.Empty);
            itemQueryOptions.InnerXml = @"<IncludeMandatoryColumns>False</IncludeMandatoryColumns> <DataInUtc>True</DataInUtc>";
            itemViewFields.InnerXml = @"<FieldRef Name = 'Title'/>";
            itemQuery.InnerXml = @"<Where><Eq><FieldRef Name='Title' /><Value Type='Text'>fff</Value></Eq></Where>";


            var node = listService.GetListItems("test List", null, itemQuery, itemViewFields, null, itemQueryOptions, null);

            var nodes = (node as XmlElement).GetElementsByTagName(@"z:row");
            foreach (XmlElement subNode in nodes)
            {
                using (var fs = File.Open(@"c:\item.xml", FileMode.Open, FileAccess.Read))
                {
                    var array = new byte[fs.Length];
                    fs.ReadAsync(array, 0, Convert.ToInt32(fs.Length), System.Threading.CancellationToken.None);


                    var listId = subNode.GetAttributeNode("ows_ID").Value;
                    listService.AddAttachment("test List", listId, fs.Name, array);
                }
            }


        }
    }
}