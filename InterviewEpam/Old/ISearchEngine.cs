using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InterviewEpam.Old
{
    public interface ISearchEngine
    {
        #region ISearchEngine Members

        string File { get; set; }
        XDocument xdoc { get; set; }

        #endregion

        void LoadFile();
        List<string> Search(string query);

        
    }
}
