using KEM.Commun.Filters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace KEM.Commun.Exceptions
{
    [TestClass]
    public class FunctionalErrorExceptionTest : Exception
    {
        [TestMethod]
        public void ForAFunctionalErrorException()
        {
            //Arrange
            var dut = new FunctionalErrorException();

            //Assert
            Assert.IsNotNull(dut);
        }

        [TestMethod]
        public void ForAFunctionalErrorException_WhenMessageIsInjected()
        {
            //Arrange
            var expectedMsg = "Test";
            var dut = new FunctionalErrorException(expectedMsg);

            //Assert
            Assert.AreEqual(expectedMsg, dut.Message);
        }

        [TestMethod]
        public void ForAFunctionalErrorException_WhenMessageAndExceptionAreInjected()
        {
            //Arrange
            var expectedMsg = "Test";
            var expectedRes = new Exception(expectedMsg);
            var dut = new FunctionalErrorException(expectedMsg, expectedRes);

            //Assert
            Assert.AreEqual(expectedMsg, dut.Message);
            Assert.AreEqual(expectedRes, dut.InnerException);
        }

        [TestMethod]
        public void ForAFunctionalErrorException_WhenWeInjectAnMessageAndNullException()
        {
            //Arrange
            var expectedMsg = "Test";
            var dut = new FunctionalErrorException(expectedMsg, null);

            //Assert
            Assert.AreEqual(expectedMsg, dut.Message);
        }

        [TestMethod]
        public void ForAFunctionalErrorException_WhenWeInjectAnErrorDetail()
        {
            //Arrange
            var expectedRes = new ErrorDetail();
            var dut = new FunctionalErrorException(expectedRes);

            //Assert
            Assert.AreEqual(expectedRes, dut.Detail);
        }

        [TestMethod]
        public void ForAFunctionalErrorException_WhenWeInjectParams()
        {
            //Arrange
            var codeHttp = HttpStatusCode.BadRequest;
            var codeMessage = "Test";

            //Act
            var dut = new FunctionalErrorException(codeHttp, codeMessage);

            //Assert
            Assert.AreEqual(codeHttp, dut.Detail.CodeHttp);
            Assert.AreEqual(codeMessage, dut.Detail.CodeMessage);
        }

    }
}
