using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KEM.Commun.Exceptions
{
    [TestClass]
    internal class BrokerExceptionTest : Exception
    {
        private const string EXPECTED_MSG = "Exception of type 'KEM.Commun.Exceptions.BrokerException' was thrown.";

        [TestMethod]
        public void ForABrokerException()
        {
            //Arrange
            var dut = new BrokerException();

            //Act

            //Assert
            Assert.IsNotNull(dut);
        }

        [TestMethod]
        public void ForABrokerException_WhenWeGiveAnHttpMessageCode()
        {
            //Arrange
            var expectedRes = HttpStatusCode.BadRequest;
            var expectedMsg = "Test";

            //Act
            var dut = new BrokerException(expectedRes, expectedMsg);

            //Assert
            Assert.AreEqual(expectedRes, dut.CodeHttp);
            Assert.AreEqual(expectedMsg, dut.Message);
        }

        [TestMethod]
        public void ForABrokerException_WhenWeInjectMessage()
        {
            //Arrange
            string? expectedMsg = "Test";

            //Act
            var dut = new BrokerException(expectedMsg);

            //Assert
            Assert.AreEqual(expectedMsg, dut.Message);
        }

        [TestMethod]
        public void ForABrokerException_WhenWeInjectNullMessage_TheGiveDefaultMessage()
        {
            //Arrange
            string? msg = null;

            //Act
            var dut = new BrokerException(msg);

            //Assert
            Assert.AreEqual(EXPECTED_MSG, dut.Message);
        }

        [TestMethod]
        public void ForABrokerException_WhenWeInjectAnMessageAndException()
        {
            //Arrange
            string? expectedMsg = "Test";
            Exception? expectedRes = new Exception(expectedMsg);

            //Act
            var dut = new BrokerException(expectedMsg, expectedRes);

            //Assert
            Assert.AreEqual(expectedMsg, dut.Message);
            Assert.AreEqual(expectedRes, dut.InnerException);
        }

        [TestMethod]
        public void ForABrokerException_WhenWeInjectAnNullMessageAndException()
        {
            //Arrange
            string? msg = null;
            Exception? expectedRes = null;

            //Act
            var dut = new BrokerException(msg, expectedRes);

            //Assert
            Assert.AreEqual(EXPECTED_MSG, dut.Message);
            Assert.AreEqual(expectedRes, dut.InnerException);
        }
    }
}
