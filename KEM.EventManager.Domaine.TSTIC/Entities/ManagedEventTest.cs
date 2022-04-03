using AutoFixture;
using KEM.EventManager.Domaine.Builders;
using KEM.EventManager.Domaine.Entities.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEM.EventManager.Domaine.TSTIC.Entities
{
    [TestClass]
    internal class ManagedEventTest { 

        [TestMethod]
        public void ForAManagedEventBuilder_WhenWeCallBuild_ThenTheManagedEventIsCreatedCorrectly()
        {
            // Arrange
            Fixture fixture = new Fixture();
            long fLong = fixture.Create<long>();
            string fString = fixture.Create<string>();
            DateTime fDateTime = fixture.Create<DateTime>();

            // Act
            ManagedEvent formulaire = new ManagedEventBuilder()
                .WithId(fLong)
                .WithName(fString)
                .WithDescription(fString)
                .WithStartTime(fDateTime)
                .WithFinishTime(fDateTime)
                .Build();

            // Assert
            Assert.AreEqual(formulaire.Id, fLong);
            Assert.AreEqual(formulaire.Name, fString);
            Assert.AreEqual(formulaire.Description, fString);
            Assert.AreEqual(formulaire.StartTime, fDateTime);
            Assert.AreEqual(formulaire.FinishTime, fDateTime);
        }
    }
}
