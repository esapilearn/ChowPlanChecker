﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ESAPX_StarterUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESAPIX.Constraints;

namespace ESAPX_StarterUI.ViewModels.Tests
{
    [TestClass()]
    public class CTDateConstraintTests
    {
        [TestMethod()]
        public void ConstrainCTDate_OldCT_FailsCorrectly()
        {
            // Arrange
            var ctDate = DateTime.Now.AddDays(-61);

            // Act
            var constraint = new CTDateConstraint();
            var actual = constraint.ConstrainCTDate(ctDate).ResultType;

            //Assert
            var expected = ResultType.ACTION_LEVEL_3;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void CTDateConstraintPassesCorrectly()
        {
            //Arrange
            var ctDate = DateTime.Now.AddDays(-59);

            //Act
            var actual = new CTDateConstraint().ConstrainCTDate(ctDate).ResultType;

            //Assert
            var expected = ResultType.PASSED;
            Assert.AreEqual(expected, actual);
        }
    }
}