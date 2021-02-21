using Nautilus.Core.Models;
using System;
using System.Collections.Generic;
using System.Xml;

namespace Nautilus.XmlProvider
{
    public class Provider
    {

        private List<ParamModel> Get()
        {
            List<ParamModel> model = new List<ParamModel>();

            XmlNodeList List;
            if (master == null)
                List = xmldoc.ChildNodes;
            else
                List = master.ChildNodes;

            foreach (XmlNode item in List)
            {
                string urlkey = key + "/" + item.Name;


                ParamModel cls = new ParamModel();
                cls.Name = item.Name;
                cls.Value = item.InnerText;
                cls.Url = urlkey;
                if (item.HasChildNodes)
                    cls.InnerValue = GetClass(urlkey, item);
                model.Add(cls);

            }
            return model;
        }
        private List<ParamModel> GetClass(string key, XmlNode master = null)
        {
            List<ParamModel> model = new List<ParamModel>();

            XmlNodeList List;
            if (master == null)
                List = xmldoc.ChildNodes;
            else
                List = master.ChildNodes;

            foreach (XmlNode item in List)
            {
                string urlkey = key + "/" + item.Name;


                ParamModel cls = new ParamModel();
                cls.Name = item.Name;
                cls.Value = item.InnerText;
                cls.Url = urlkey;
                if (item.HasChildNodes)
                    cls.InnerValue = GetClass(urlkey, item);
                model.Add(cls);

            }
            return model;
        }

    }
}
