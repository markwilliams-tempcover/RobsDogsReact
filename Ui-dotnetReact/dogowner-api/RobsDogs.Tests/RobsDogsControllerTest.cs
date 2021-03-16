using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RobsDogs.Controllers;
using RobsDogs.Models.Contracts;
using RobsDogs.Models.Domain;

namespace RobsDogs.Tests
{
    [TestClass]
    public class RogsDogsControllerTest
    {
        [TestMethod]
        public async Task Index()
        {
            // Arrange
            var mockRepo = new Mock<IDogOwnerRepository>();
            mockRepo
                .Setup(r => r.GetAllDogOwners())
                .ReturnsAsync(GetTestDogOwners());

            var controller = new RobsDogsController(mockRepo.Object);

            // Act
            var result = controller.GetAllDogOwners();

            var repo = mockRepo.Object;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(repo);
            Assert.IsNotNull(repo.GetAllDogOwners());
            Assert.IsInstanceOfType(await repo.GetAllDogOwners(), typeof(List<DogOwner>));
            Assert.IsTrue((await repo.GetAllDogOwners()).Any());
        }

        private IEnumerable<DogOwner> GetTestDogOwners()
        {
            return new List<DogOwner>{
                new DogOwner("Test Owner 1",
                    new List<string> { "Dog 1", "Dog 2" })
            };
        }
    }
}