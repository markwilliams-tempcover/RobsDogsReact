using System.Collections.Generic;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Ui.Controllers;
using Ui.Entities;
using Ui.Services;

namespace Ui.Tests.Controllers
{
	[TestClass]
	public class RobsDogsControllerTest
	{
		[TestMethod]
		public void Index()
		{
            // Arrange
            var mockRepo = new Mock<IDogOwnerService>();
            mockRepo
                .Setup(r => r.GetAllDogOwners())
                .Returns(GetTestDogOwners());

			RobsDogsController controller = new RobsDogsController(mockRepo.Object);

			// Act
			ViewResult result = controller.Index() as ViewResult;

            var repo = mockRepo.Object;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(repo);
            Assert.IsNotNull(repo.GetAllDogOwners());
            Assert.IsInstanceOfType(repo.GetAllDogOwners(), typeof(List<DogOwner>));
            Assert.IsTrue(repo.GetAllDogOwners().Count > 0);
		}

        private List<DogOwner> GetTestDogOwners()
        {
            return new List<DogOwner>{
                new DogOwner
                {
                    OwnerName = "Test Owner 1",
                    DogNames = new List<string> { "Dog 1", "Dog 2" }
                }
            };
        }
    }
}