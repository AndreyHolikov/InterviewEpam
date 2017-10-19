using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewEpam.BusinessEntities;

namespace InterviewEpam.BusinessComponents.Interfaces
{
    interface IDataManager
    {
        List<string> Search(string query);
        List<Entity> GetAll();
    }
}
