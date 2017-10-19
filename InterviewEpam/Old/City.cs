using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InterviewEpam.Old
{
    class City : ISearchEngine
    {
        public string File { get; set; }
        public XDocument xdoc { get; set; }

        public City()
        {
            File = "city.xml";
        }

        public void LoadFile()
        {
            xdoc = XDocument.Load(File);
        }

        public List<string> Search(string query)
        {
            List<string> result = new List<string> { };

            foreach (XElement xElement in xdoc.Element("cities").Elements())
            {
                foreach (XAttribute xAttribute in xElement.Attributes())
                {
                    if (xAttribute.Value.IndexOf(query) > 0)
                    {
                        result.Add("File: " + File);
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
                        result.Add("File: " + File);
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
