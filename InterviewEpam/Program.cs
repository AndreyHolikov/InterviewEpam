using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InterviewEpam
{
    class Program
    {
        static void Main(string[] args)
        {
            string query = "at";
            //query = Console.ReadLine();

            var searchEngines = new List<ISearchEngine>
            {
                new Phone(),
                new Book(),
                new City(),
                new User()
            };

            

            Console.WriteLine("Query :" + query);
            foreach (var searchEngine in searchEngines)
            {
                var results = searchEngine.Search(query);

                foreach(string result in results)
                {
                    Console.WriteLine(result);
                }
            }

            //SearchEngine searchEngineDI = new SearchEngine(new Phone());
            //var results = searchEngineDI.Search(query);

            Console.ReadLine();
        }
    }
}
