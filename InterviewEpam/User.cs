using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InterviewEpam
{
    class User : ISearchEngine
    {
        public string File { get; set; }
        public XDocument xdoc { get; set; }

        public User()
        {
            File = "user.xml";
        }

        public void LoadFile()
        {
            xdoc = XDocument.Load(File);
        }

        public List<string> Search(string query)
        {
            return new List<string>() { };
            //throw new NotImplementedException();
        }
    }
}
