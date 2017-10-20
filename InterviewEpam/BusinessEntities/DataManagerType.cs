using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewEpam.BusinessComponents.Components;

namespace InterviewEpam.BusinessEntities
{
    public class DataManagerType : IEnumerable // TODO: Нужен ли IEnumerable ?
    {
        //public List<Type> types = new List<Type>() {
        //   BookDataManager, CityDataManager, PhoneDataManager, UserDataManager };

        public List<string> types = new List<string>() {
           "BookDataManager", "CityDataManager", "PhoneDataManager", "UserDataManager" };

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
