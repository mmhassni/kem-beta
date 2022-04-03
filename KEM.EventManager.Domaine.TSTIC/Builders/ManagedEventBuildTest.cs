using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KEM.EventManager.Domaine.Builders;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFixture;

namespace KEM.EventManager.Domaine.TSTIC.Builders
{
    [TestClass]
    internal class ManagedEventBuildTest
    {
        [TestMethod]
        public void ElementBuilder_GeneratedCorrectly()
        {
            //Arrange
            Fixture fixture = new Fixture();
            long fLong = fixture.Create<long>();
            string fString = fixture.Create<string>();
            DateTime fDate = fixture.Create<DateTime>();

            //Act
            var content = new ManagedEventBuilder();
            var withId = content.WithId(fLong);
            var withType = content.WithName(fString);
            var withVersion = content.WithDescription(fString);
            var withProvenance = content.WithStartTime(fDate);
            var withDate = content.WithFinishTime(fDate);

            //Assert
            Assert.IsNotNull(withId);
            Assert.IsNotNull(withType);
            Assert.IsNotNull(withVersion);
            Assert.IsNotNull(withProvenance);
            Assert.IsNotNull(withDate);
        }
    }
}
