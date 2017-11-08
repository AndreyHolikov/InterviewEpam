using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewEpam.BusinessEntities;

namespace InterviewEpam.BusinessComponents.Components
{
    public static class DataManagerFactory //Зачем делать abstract?
    {
        public static DataManager CreateDataManager(DataManagerType dataManagerType) // FactoryMethod
        {
            DataManager returnDataManager;
            string fileName = dataManagerType.ToString() + ".xml";
            switch ( dataManagerType )
            {
                case DataManagerType.Book:
                    returnDataManager = new BookDataManager(fileName);
                    break;
                case DataManagerType.City:
                    returnDataManager = new CityDataManager(fileName);
                    break;
                case DataManagerType.Phone:
                    returnDataManager = new PhoneDataManager(fileName);
                    break;
                case DataManagerType.User:
                    returnDataManager = new UserDataManager(fileName);
                    break;
                default:
                    // TODO: Проверить как точно генерируется исключение.
                    throw new Exception();
            }
            //Заполняем название файла.
            return returnDataManager;
        }
    }
}
