using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InterviewEpam
{
    class Phone: ISearchEngine
    {
        public string File { get; set; }
        public XDocument xdoc { get; set; }

        public Phone()
        {
            File = "phone.xml";
        }

        public void LoadFile()
        {
            xdoc = XDocument.Load(File);
        }

        public List<string> Search(string query)
        {
            List<string> result = new List<string> { };

            

            foreach (XElement phoneElement in xdoc.Element("phones").Elements("phone"))
            {
                XAttribute nameAttribute = phoneElement.Attribute("name");
                XElement companyElement = phoneElement.Element("company");
                XElement priceElement = phoneElement.Element("price");

                if (nameAttribute.Value.IndexOf(query)>0 || companyElement.Value.IndexOf(query) > 0 || priceElement.Value.IndexOf(query) > 0)
                {
                    result.Add("File: " + File);

                    result.Add("Смартфон: " + nameAttribute.Value);
                    result.Add("Компания: " + companyElement.Value);
                    result.Add("Цена: " + priceElement.Value);

                    result.Add("");
                }
            }

            return result;
        }
    }
}
