using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InterviewEpam
{
    class Book : ISearchEngine
    {
        string file = "book.xml";

        public List<string> Search(string query)
        {
            List<string> result = new List<string> { };

            XDocument xdoc = XDocument.Load(file);

            foreach (XElement xElement in xdoc.Element("catalog").Elements())
            {
                foreach(XAttribute xAttribute in xElement.Attributes())
                {
                    if(xAttribute.Value.IndexOf(query) > 0)
                    {
                        result.Add("File: " + file);
                        result.Add(xElement.Name.ToString() + ":" + xElement.Value.ToString());
                        result.Add(xAttribute.Name.ToString() + ":" + xAttribute.Value.ToString());
                        result.Add("");
                        break;
                    }
                }

                foreach (XElement xElementChild in xElement.Elements())
                {
                    if (xElementChild.Value.IndexOf(query) > 0)
                    {
                        result.Add("File: " + file);
                        result.Add(xElement.Name.ToString() + ":" + xElement.Value.ToString());
                        result.Add(xElementChild.Name.ToString() + ":" + xElementChild.Value.ToString());
                        result.Add("");
                        break;
                    }
                }
              
                
            }

            return result;
        }
    }
}
