using System;
using Infrastructure.DataBase.Entities;
using Infrastructure.DataBase.Interfaz;

namespace Infrastructure.DataBase.Repositorys
{
	public class CarRepository : ICarRepository
    {
        public void CreateCar(Car car)
        {
        }

        public void UpdateCar(Car car)
        {
        }

        public void DeleteCar(int carID)
        {
        }

        public IEnumerable<Car> GetAll()
        {
            return null;
        }

        public Car GetById(int carID)
        {
            return null;
        }

        public void Dispose(int carID)
        {
        }



    }
}

