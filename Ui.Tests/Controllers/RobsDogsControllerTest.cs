using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Ui.Controllers;
using Ui.Entities;
using Ui.Interfaces;
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
            var mockRepository = new Mock<IDogOwnerService>();
            mockRepository
                .Setup(r => r.GetAllDogOwners())
                .Returns(new List<DogOwner>{
					new DogOwner
					{
						OwnerName = "Mock Dog Owner",
						DogNames = new List<string> { "Mock Dog One", "Mock Dog Two", "Mock Dog Three", }
					}
				});

            RobsDogsController controller = new RobsDogsController(mockRepository.Object);

			// Act
			ViewResult result = controller.Index() as ViewResult;

			// Assert
			Assert.IsNotNull(result);
			// Should be testing/verifying call to GetAllDogOwners and subsequent methods down the stack.
			Assert.IsNotNull(mockRepository.Object);
            Assert.IsNotNull(mockRepository.Object.GetAllDogOwners());
			Assert.IsTrue(mockRepository.Object.GetAllDogOwners().Any());
            // Moq is installed to help you.
        }
	}
}