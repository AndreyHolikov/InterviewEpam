using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewEpam.BusinessComponents.Interfaces;
using InterviewEpam.BusinessEntities;
using System.Xml.Linq;

namespace InterviewEpam.BusinessComponents.Components
{
    public abstract class DataManager : IDataManager
    {
        public XDocument Xdoc;


        public List<string> Search(string query)
        {
            string file = "????";
            // TODO: откуда взять название файла? из DataManagerFactory?
            LoadXmlFile(file);
            List<Entity> entities = this.GetAll();

            return this.Search(query, entities);
        }


        public abstract List<Entity> GetAll();
        public abstract List<string> Search(string query, IEnumerable<Entity> entities);


        public void LoadXmlFile(string file)
        {
            Xdoc = XDocument.Load(file);
        }
    }
}
