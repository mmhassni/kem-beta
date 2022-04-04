using AutoMapper;
using KEM.EventManager.API.Controllers;
using KEM.EventManager.Application.Services;
using KEM.EventManager.Domaine.Builders;
using KEM.EventManager.Domaine.Entities.Events;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEM.EventManager.API.TSTIC.Controllers
{
    [TestClass]
    internal class ManagedEventControllerTest
    {
        private readonly Mock<IMapper> _mapper = new Mock<IMapper>();
        private readonly Mock<ILogger<ManagedEventController>> _logger = new Mock<ILogger<ManagedEventController>>();
        private readonly Mock<IManagedEventService> _managedEventService = new Mock<IManagedEventService>();

        [TestMethod]
        public void ListingEventList_AllItems_ReturnManagedEventList()
        {
            //Arrange
            var managedEventController = new ManagedEventController(
                _mapper.Object,
                _logger.Object,
                _managedEventService.Object);
            var  expectedKumojinEventList = Task.FromResult(new List<ManagedEvent>
                {
                    new ManagedEventBuilder()
                        .WithId(1)
                        .WithName("Event Test")
                        .WithDescription("Test Description")
                        .WithStartTime(new DateTime())
                        .WithFinishTime(new DateTime().AddDays(5))
                        .Build()
                });
            //Act
            var resultat = managedEventController.ListAll();

            //Assert
            Assert.AreEqual(expectedKumojinEventList, resultat);

        }

    }
}
