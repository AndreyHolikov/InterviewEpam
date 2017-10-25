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
        // Зачем его делать abstract? (ты советовал в Viber`e)
        private string FileName { get; set; } 
        public XDocument Xdoc;

        public DataManager(string fileName)
        {
            this.FileName = "Xml/" + fileName;
            LoadXmlFile();
        }

        public List<string> Search(string query)
        {
            LoadXmlFile();
            List<Entity> entities = this.GetAll();

            return this.Search(query, entities);
        }


        public abstract List<Entity> GetAll();
        public abstract List<string> Search(string query, IEnumerable<Entity> entities);


        private void LoadXmlFile()
        {
            Xdoc = XDocument.Load(FileName);
        }
    }
}
