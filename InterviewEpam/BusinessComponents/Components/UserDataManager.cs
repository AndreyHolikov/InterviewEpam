using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewEpam.BusinessComponents.Interfaces;
using InterviewEpam.BusinessEntities;

namespace InterviewEpam.BusinessComponents.Components
{
    public class UserDataManager : DataManager
    {
        public override List<Entity> GetAll()
        {
            List<Entity> entities = new List<Entity>();

            var items = from xe in this.Xdoc.Element("users").Elements("person")
                            //where xe.Element("company").Value == "Samsung"
                        select new User
                        {
                            // TODO: Id - ???
                            Name = xe.Element("name").Value.ToString(),
                            Post = xe.Element("post").Value.ToString(),
                            Department = xe.Element("department").Value.ToString(),
                            Mobileno = xe.Element("mobileno").Value.ToString(),
                            City = xe.Element("city").Value.ToString()
                        };

            entities = items.ToList<Entity>();

            return entities;
        }

        public override List<string> Search(string query, IEnumerable<Entity> entities)
        {
            List<string> results = new List<string>();
            var resultEntities = from entity in (IEnumerable<User>)entities
                                 where entity.Name == query
                                 || entity.City == query
                                 || entity.Department == query
                                 || entity.Mobileno == query
                                 || entity.Post == query
                                 select entity.Name;

            results = resultEntities.ToList<string>();
            return results;
        }
    }
}
