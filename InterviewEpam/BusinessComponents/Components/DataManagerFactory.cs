using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewEpam.BusinessEntities;

namespace InterviewEpam.BusinessComponents.Components
{
    class DataManagerFactory
    {
        public DataManager CreateDataManager(DataManagerType dataManagerType)
        {
            return new BookDataManager();
        }
    }
}
