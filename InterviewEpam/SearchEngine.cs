using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewEpam
{
    public class SearchEngine: ISearchEngine
    {

        public virtual List<string> Search(string query)
        {
            List<string> result = new List<string> { };

            //SearchEngine work!
            result.Add("SearchEngine Find :" + query);

            return result;
        }

        //Example Test
        public int Summ(int x, int y)
        {
            return x + y;
        }
    }
}
