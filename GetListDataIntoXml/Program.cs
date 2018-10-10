using System;
using System.Collections.Generic;


namespace GetListDataIntoXml
{
    class Program
    {
        static void Main(string[] args)
        {
            var demo = new GetSPListDataDemo("http://win-2d10c362gie/", "Lists/test List");
            var xml = demo.GetListData(1);
        }
    }
}
