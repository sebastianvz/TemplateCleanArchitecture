using Xunit;
using Domain.Entities;
using Application.UseCases.CarFunctions;
using Moq;
using Application.Contracts;

namespace TemplateCleanArchitectureTest.Appplication.UseCases
{
	public class CarServicesTest
	{
		[Fact()]
		public void SusccessCarCreation()
        {
			//Setup
			Car car = new Car()
			{
				Brand = "Audi",
				Year = 2022,
				Price = 6000,
				Name = "RS"
			};


			var carRepository = new Mock<ICarRepository>();
			var carService = new CarService(carRepository.Object);

			//action
			carService.CreateCar(car);

			carRepository.Verify(x => x.Insert(car), Times.Once);

		}

	}
}

