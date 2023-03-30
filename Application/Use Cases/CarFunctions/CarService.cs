using System;
using System.Runtime.ConstrainedExecution;
using Application.Contracts;
using Domain.Entities;

namespace Application.UseCases.CarFunctions
{
	public class CarService
	{

        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public void CreateCar(Car car)
        {
            _carRepository.CreateCar(car);
        }

        public void UpdateCar(Car car)
        {
            _carRepository.UpdateCar(car);
        }

        public void DeleteCar(Car car)
        {
            _carRepository.DeleteCar(car.IdCar);
        }
    }
}

