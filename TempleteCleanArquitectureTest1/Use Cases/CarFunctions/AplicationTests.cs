using Application.Contracts;
using Domain.Entities;
using Moq;
using Xunit;

namespace Application.UseCases.CarFunctions.Tests
{
    public class AplicationTests
    {
        [Fact()]
        public void Deberia_Guardar_Un_Carro_Exitosamente()
        {
            //Configuración
            var car = new Car
            {
                Brand = "Chevrolet",
                Year = 2015,
                Price = 67_000_000,
                Name = "Seddan"
            };

            var carRepository = new Mock<ICarRepository>();
            var carService = new CarService(carRepository.Object);

            carRepository.Setup(x => x.SaveChanges()).Returns(1);

            //Acción
            carService.CreateCar(car);

            //Afirmaciones
            carRepository.Verify(x => x.Insert(car), Times.Once);
            carRepository.Verify(x => x.SaveChanges(), Times.Once);
        }

        [Fact()]
        public void Deberia_Generar_Una_Exception_Si_No_Guarda_El_Carro_Exitosamente()
        {
            // Configuración
            var car = new Car();
            var carRepository = new Mock<ICarRepository>();
            carRepository.Setup(x => x.SaveChanges()).Returns(0);
            var carService = new CarService(carRepository.Object);

            // Acción y afirmación
            var ex = Assert.Throws<Exception>(() => carService.CreateCar(car));
            Assert.Equal("No fue posible guardar los cambios", ex.Message);
        }
    }
}