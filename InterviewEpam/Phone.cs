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
        string file = "phone.xml";

        public List<string> Search(string query)
        {
            List<string> result = new List<string> { };

            XDocument xdoc = XDocument.Load(file);

            foreach (XElement phoneElement in xdoc.Element("phones").Elements("phone"))
            {
                XAttribute nameAttribute = phoneElement.Attribute("name");
                XElement companyElement = phoneElement.Element("company");
                XElement priceElement = phoneElement.Element("price");

                if (nameAttribute.Value.IndexOf(query)>0 || companyElement.Value.IndexOf(query) > 0 || priceElement.Value.IndexOf(query) > 0)
                {
                    result.Add("File: " + file);

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
