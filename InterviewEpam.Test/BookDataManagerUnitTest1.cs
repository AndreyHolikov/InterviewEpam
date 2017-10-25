using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewEpam.BusinessComponents.Components;
using InterviewEpam.BusinessEntities;
using System.Collections.Generic;

namespace InterviewEpam.Test
{
    [TestClass]
    public class BookDataManagerUnitTest1
    {
        [TestMethod]
        public void GetAll_returnFirstId_bk101()
        {
            //arrange
            string excpected = "bk101";

            //act
            BookDataManager bm = new BookDataManager(DataManagerType.Book + ".xml");
            string actual = bm.GetAll()[0].Id;

            //assert
            Assert.AreEqual(excpected, actual);
        }

        [TestMethod]
        public void Search()
        {
            //arrange
            string query = "Kim";
            BookDataManager bm = new BookDataManager(DataManagerType.Book + ".xml");
            List<Entity> actualEntities = bm.GetAll();

            string excpected = "Midnight Rain";

            //act
            string actual = bm.Search(query, actualEntities)[0];

            //assert
            Assert.AreEqual(excpected, actual);
        }
    }
}
