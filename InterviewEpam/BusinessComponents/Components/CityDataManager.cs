using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewEpam.BusinessComponents.Interfaces;
using InterviewEpam.BusinessEntities;

namespace InterviewEpam.BusinessComponents.Components
{
    public class CityDataManager : DataManager
    {
        public CityDataManager(string fileName) : base(fileName)
        { }

        public override List<Entity> GetAll()
        {
            List<Entity> entities = new List<Entity>();

            var items = from xe in this.Xdoc.Element("cities").Elements("city")
                            //where xe.Element("company").Value == "Samsung"
                        select new City
                        {
                            // TODO: Id - ???
                            Name = xe.Element("cityName").Value.ToString(),
                            Country = xe.Element("cityCountry").Value.ToString()
                        };

            entities = items.ToList<Entity>();

            return entities;
        }

        public override List<string> Search(string query, IEnumerable<Entity> entities)
        {
            List<string> results = new List<string>();

            IEnumerable<City> cities = (IEnumerable<City>)entities;
            var resultEntities = cities.Where(c => c.Name == query)
                          .Select(c => c.Name);

            // TODO: настроить поиск по всем полям.

            results = resultEntities.ToList<string>();

            return results;
        }
    }
}
