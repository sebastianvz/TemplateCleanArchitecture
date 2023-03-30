using System;
using Domain.Entities;

namespace Application.Contracts
{
	public interface ICarRepository 
	{
        public void CreateCar(Car car);

        public void UpdateCar(Car car);

        public void DeleteCar(int carID);

        public IEnumerable<Car> GetAll();

        public Car GetById(int carID);

        public void Dispose();
    }
}

