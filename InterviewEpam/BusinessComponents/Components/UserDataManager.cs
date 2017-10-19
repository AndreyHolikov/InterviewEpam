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

            return entities;
        }

        public override List<string> Search(string query, IEnumerable<Entity> entities)
        {
            List<string> results = new List<string>();

            return results;
        }
    }
}
