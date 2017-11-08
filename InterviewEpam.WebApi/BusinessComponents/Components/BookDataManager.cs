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
            //List<Entity> listEntity = new List<Entity>(entities);
            List<Book> books = new List<Book>();
            foreach (Entity entitiy in entities)
            {
                books.Add((Book)entitiy);
            }

            IEnumerable<string> resultEntities = from entity in books
                                 where entity.Title == query 
                                        || entity.Author == query
                                        || entity.Genre == query
                                        || entity.Price == query
                                        || entity.Description == query
                                 select entity.Title;
            List<string> results = new List<string>();
            foreach (var result in resultEntities)
            {
                results.Add(result);
            }
            return results;
        }
    }
}
