using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewEpam.BusinessComponents.Interfaces;
using InterviewEpam.BusinessEntities;

namespace InterviewEpam.BusinessComponents.Components
{
    public class BookDataManager : DataManager
    {
        public BookDataManager(string fileName) : base(fileName)
        { }

        public override List<Entity> GetAll()
        {
            List<Entity> entities = new List<Entity>();

            var items = from xe in this.Xdoc.Element("catalog").Elements("book")
                        //where xe.Element("company").Value == "Samsung"
                        select new Book
                        {
                            Id = xe.Attribute("id").Value.ToString(),
                            Author = xe.Element("author").Value.ToString(),
                            Title = xe.Element("title").Value.ToString(),
                            Genre = xe.Element("genre").Value.ToString(),
                            Price = xe.Element("price").Value.ToString(),
                            Publish_date = xe.Element("publish_date").Value.ToString(),
                            Description = xe.Element("description").Value.ToString()
                        };

            entities = items.ToList<Entity>();

            return entities;
        }

        public override List<string> Search(string query, IEnumerable<Entity> entities)
        {
            List<string> results = new List<string>();
            //Имя теста:	Search
            //            Полное имя теста: InterviewEpam.Test.BookDataManagerUnitTest1.Search
            //          Источник теста: H:\__Project 2017\Applications VS\ZpnInterviewEpam\InterviewEpam.Test\BookDataManagerUnitTest1.cs : строка 28
            //Выходные данные теста: Сбой
            //Продолжительность теста: 0:00:00,0300652

            //Результат Трассировка стека:
            //            в InterviewEpam.BusinessComponents.Components.BookDataManager.Search(String query, IEnumerable`1 entities) в H:\__Project 2017\Applications VS\ZpnInterviewEpam\InterviewEpam\BusinessComponents\Components\BookDataManager.cs:строка 41
            //   в InterviewEpam.Test.BookDataManagerUnitTest1.Search() в H:\__Project 2017\Applications VS\ZpnInterviewEpam\InterviewEpam.Test\BookDataManagerUnitTest1.cs:строка 37
            //Результат Сообщение:	
            //Метод проверки InterviewEpam.Test.BookDataManagerUnitTest1.Search выдал исключение:
            //            System.InvalidCastException: Не удалось привести тип объекта "System.Collections.Generic.List`1[InterviewEpam.BusinessEntities.Entity]" к типу "System.Collections.Generic.IEnumerable`1[InterviewEpam.BusinessEntities.Book]"..

            //List<Entity> listEntity = new List<Entity>(entities);
            List<Book> books = new List<Book>();
            foreach (Entity entitiy in entities)
            {
                books.Add((Book)entitiy);
            }

            var resultEntities = from entity in books
                                 where entity.Title == query 
                                        || entity.Author == query
                                        || entity.Genre == query
                                        || entity.Price == query
                                        || entity.Description == query
                                 select entity.Title;

            results = resultEntities.ToList<string>();
            return results;
        }
    }
}
