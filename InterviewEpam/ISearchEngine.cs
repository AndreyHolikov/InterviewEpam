using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InterviewEpam
{
    interface ISearchEngine
    {
        List<string> Search(string query);
    }
}
