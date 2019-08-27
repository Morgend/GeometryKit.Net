﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathKit;
using MathKit.Geometry;

namespace MathKitTest.Geometry
{
    [TestClass]
    public class AngleTest
    {
        [TestMethod]
        public void TestDegrees()
        {
            Angle a = new Angle(MathConst.PI / 4.0);

            Assert.AreEqual(45.0, a.Degrees, MathConst.EPSYLON);

            a.Degrees = -10;

            Assert.AreEqual(-MathConst.PI / 18.0, a.Radians, MathConst.EPSYLON);
        }
    }
}