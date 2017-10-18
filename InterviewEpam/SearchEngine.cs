using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewEpam
{
    public class SearchEngine
    {
        ISearchEngine searchEngine;

        public SearchEngine(ISearchEngine searchEngine)
        {
            this.searchEngine = searchEngine;
        }

        public List<string> Search(string query)
        {
            return searchEngine.Search(query);
        }

        //// Если ставлю public, то показывает ошибку:
        ////Ошибка CS0051  Несогласованность по доступности: доступность типа параметра "ISearchEngine" ниже доступности метода "SearchEngine.SearchEngine(ISearchEngine)"	InterviewEpam E:\__Project 2017\Application VS\InterviewEpam\InterviewEpam\InterviewEpam\SearchEngine.cs	15	Активно
        //private ISearchEngine _searchEngine;
        
        //// Если ставлю public, то показывает ошибку:
        ////Ошибка CS0051 
        //private SearchEngine(ISearchEngine searchEngine)
        //{
        //    _searchEngine = searchEngine;
        //}

        //public SearchEngine() { }

        //public virtual List<string> Search(string query)
        //{
        //    //DI
        //    //List<string> result = _searchEngine.Search(query);
        //    List<string> result = new List<string> { };

        //    //SearchEngine work!
        //    result.Add("SearchEngine Find :" + query);

        //    return result;
        //}

        //Example Test
        public int Summ(int x, int y)
        {
            return x + y;
        }
    }
}
