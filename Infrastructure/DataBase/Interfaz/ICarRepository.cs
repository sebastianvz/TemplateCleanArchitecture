using System;
using Infrastructure.DataBase.Entities;

namespace Infrastructure.DataBase.Interfaz
{
	public interface ICarRepository 
	{
        public void CreateCar(Car car);

        public void UpdateCar(Car car);

        public void DeleteCar(int carID);

        public IEnumerable<Car> GetAll();

        public Car GetById(int carID);

        public void Dispose(int carID);
    }
}

