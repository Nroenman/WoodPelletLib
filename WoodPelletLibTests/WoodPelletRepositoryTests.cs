﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using WoodPelletLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodPelletLib.Tests
{
    [TestClass()]
    public class WoodPelletRepositoryTests
    {
        [TestMethod()]
        public void GetAllWoodPelletTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }


        //tester på brand længde
        [TestMethod()]
        public void WoodPelletBrandTest(WoodPellet woodPellet)
        {
            WoodPellet BilligPille = new WoodPellet();
            woodPellet.Brand = "BilligPille";


            Assert.IsTrue(BilligPille.Brand.Length >= 2);
        }



    }
}