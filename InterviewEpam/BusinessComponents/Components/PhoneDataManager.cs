using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewEpam.BusinessComponents.Interfaces;
using InterviewEpam.BusinessEntities;

namespace InterviewEpam.BusinessComponents.Components
{
    public class PhoneDataManager : DataManager
    {
        public override List<Entity> GetAll()
        {
            List<Entity> entities = new List<Entity>();

            var items = from xe in this.Xdoc.Element("phones").Elements("phone")
                            //where xe.Element("company").Value == "Samsung"
                        select new Phone
                        {
                            // TODO: Id - ???
                            Name = xe.Attribute("name").ToString(),
                            Company = xe.Element("company").Value.ToString(),
                            Price = xe.Element("price").Value.ToString()
                        };

            entities = items.ToList<Entity>();

            return entities;
        }

        public override List<string> Search(string query, IEnumerable<Entity> entities)
        {
            List<string> results = new List<string>();
            var resultEntities = from entity in (IEnumerable<Phone>)entities
                                 where entity.Name == query
                                 select entity.Name;

            results = resultEntities.ToList<string>();
            return results;
        }
    }
}
