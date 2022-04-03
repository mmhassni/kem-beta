using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KEM.Commun.Exceptions
{
    [TestClass]
    public class TechnicalErrorExceptionTest : Exception
    {

        private const string EXPECTED_MSG = "Exception of type 'KEM.Commun.Exceptions.TechnicalErrorException' was thrown.";

        [TestMethod]
        public void ForATechnicallErrorException()
        {
            //Arrange
            var dut = new TechnicalErrorException();

            //Assert
            Assert.IsNotNull(dut);
        }

        [TestMethod]
        public void ForATechnicallErrorException_WhenWeInjectAMessageAndTechnicalErrorException()
        {
            //Arrange
            var expectedMsg = "Test";
            var dut = new TechnicalErrorException(expectedMsg);

            //Assert
            Assert.AreEqual(expectedMsg, dut.Message);
        }

        [TestMethod]
        public void ForATechnicallErrorException_WhenWeInjectAMessageAndException()
        {
            //Arrange
            var expectedMsg = "Test";
            var expectedRes = new Exception(expectedMsg);

            //Act
            var dut = new TechnicalErrorException(expectedMsg, expectedRes);

            //Assert
            Assert.AreEqual(expectedMsg, dut.Message);
            Assert.AreEqual(expectedRes, dut.InnerException);
        }

        [TestMethod]
        public void ForATechnicallErrorException_WhenWeInjectANullMessageAndAnException()
        {
            //Arrange
            string? expectedMsg = null;
            var expectedRes = new Exception(expectedMsg);

            //Act
            var dut = new TechnicalErrorException(expectedMsg, expectedRes);

            //Assert
            Assert.AreEqual(EXPECTED_MSG, dut.Message);
            Assert.AreEqual(expectedRes, dut.InnerException);
        }

    }
}
