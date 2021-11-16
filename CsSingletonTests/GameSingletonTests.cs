using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsSingleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsSingleton.Tests
{
    [TestClass()]
    public class GameSingletonTests
    {
        [TestMethod()]
        public void GetInstanceTest()
        {
            GameSingleton instance1 = GameSingleton.GetInstance();
            GameSingleton instance2 = GameSingleton.GetInstance();
            Assert.IsTrue(instance1 == instance2);
        }
    }
}