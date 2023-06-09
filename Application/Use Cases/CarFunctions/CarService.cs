﻿using System;
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
            _carRepository.Insert(car);
        }

        public void UpdateCar(Car car)
        {
            _carRepository.Update(car);
        }

        public void DeleteCar(Car car)
        {
            _carRepository.Delete(car.IdCar);
        }

        public Car CarbyYear(int? year){

            return _carRepository.findbyYead(year);
        }

    }
}

