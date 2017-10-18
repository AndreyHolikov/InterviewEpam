using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewEpam
{
    class User : ISearchEngine
    {
        public List<string> Search(string query)
        {
            return new List<string>() { };
            //throw new NotImplementedException();
        }
    }
}
