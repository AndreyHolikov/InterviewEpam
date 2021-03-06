﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.Practices.Unity;
using InterviewEpam.BusinessEntities;
using InterviewEpam.BusinessComponents.Components;
using InterviewEpam.BusinessComponents.Interfaces;

namespace InterviewEpam
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: перенести в тесты.
            string query = "at";
            //query = Console.ReadLine();

            // TODO: Реализовать заполнение через фабрику. 
            var dataManagers = new List<IDataManager>();
            //DataManagerFactory dataManagerFactory = new DataManagerFactory(); // Заменил на статический класс

            // TODO: Реализовать перебор DataManagerType
            //foreach(var i in DataManagerType)
            {
                dataManagers.Add(DataManagerFactory.CreateDataManager(DataManagerType.Book));
                dataManagers.Add(DataManagerFactory.CreateDataManager(DataManagerType.Book));
                dataManagers.Add(DataManagerFactory.CreateDataManager(DataManagerType.Book));
                dataManagers.Add(DataManagerFactory.CreateDataManager(DataManagerType.Book));
            }

            foreach(DataManager dataManager in dataManagers)
            {
                dataManager.Search(query);
            }

            Console.ReadLine();
        }

        // Old version
        private void Main_2()
        {
            //string query = "at";
            ////query = Console.ReadLine();

            //var searchEngines = new List<ISearchEngine>
            //{
            //    new Phone(),
            //    new Book(),
            //    new City(),
            //    new User()
            //};



            //Console.WriteLine("Query :" + query);
            //foreach (var searchEngine in searchEngines)
            //{
            //    var results = searchEngine.Search(query);

            //    foreach (string result in results)
            //    {
            //        Console.WriteLine(result);
            //    }
            //}
        }

        // Old version
        //private void DI()
        //{
        //    #region Registry

        //    // Declare a Unity Container
        //    var unityContainer = new UnityContainer();

        //    #region Simple Registry

        //    // Register IGame that when dependency is detected, it will
        //    // provide a TrivialPursuit instance

        //    unityContainer.RegisterType<ISearchEngine, Phone>();


        //    #endregion

        //    #region Property Injection

        //    // Inject a property when dependecy is resolved
        //    /*
        //    InjectionProperty injectionProperty = new InjectionProperty("Name", "Trivial Pursuit Genus Edition");
        //    unityContainer.RegisterType<IGame, TrivialPursuit>(injectionProperty);
        //    */

        //    #endregion

        //    #endregion

        //    #region Resolving

        //    #region Direct resolving

        //    // Make Unity resolve the interface, providing an instance
        //    // of TrivialPursuit class
        //    var search = unityContainer.Resolve<ISearchEngine>();

        //    // Check that the behavior is correct
        //    search.LoadFile();
        //    Console.WriteLine(string.Format("File:", search.File));
        //    Console.ReadLine();

        //    #endregion

        //    #region Indirect resolving

        //    // Instantiate an object of Table class through Unity
        //    var searchEngine = unityContainer.Resolve<SearchEngine>();

        //    string query = "at";
        //    //query = Console.ReadLine();

        //    var results = searchEngine.Search(query);

        //    foreach (string result in results)
        //    {
        //        Console.WriteLine(result);
        //    }
        //    Console.ReadLine();

        //    #endregion

        //    #region Parameter Injection

        //    // Override the constructor parameter of Table
        //    var searchEngine_2 = unityContainer.Resolve<SearchEngine>(new ParameterOverride("search", new City()));

        //    var results_2 = searchEngine.Search(query);

        //    foreach (string result in results_2)
        //    {
        //        Console.WriteLine(result);
        //    }
        //    Console.ReadLine();

        //    #endregion

        //    #endregion
        //}
    }
}
