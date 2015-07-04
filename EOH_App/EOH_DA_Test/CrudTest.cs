using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EOH_DA_Test
{
    [TestClass]
    public class CrudTest
    {
        [TestMethod]
        public void GetPerson()
        {
            EOH_DataAccess.Person person = new EOH_DataAccess.DataAccess().GetPerson();
        }

        [TestMethod]
        public void GetPerson1()
        {
            EOH_DataAccess.Person person = new EOH_DataAccess.DataAccess().GetPerson();
        }

        [TestMethod]
        public void GetPerson2()
        {
            EOH_DataAccess.Person person = new EOH_DataAccess.DataAccess().GetPerson();
        }
    }
}
