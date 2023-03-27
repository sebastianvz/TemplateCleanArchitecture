using System;
using Infrastructure.DataBase.Interfaz;
using Infrastructure.EntityModeles;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataBase.Repositorys
{ 
    public class CarRepository : ICarRepository
    {
        private readonly TestUpbContext _context;

        public CarRepository(TestUpbContext context)
        {
            _context = context;
        }
        public void CreateCar(Car car)
        {
            _context.Add(car);
        }

        public void UpdateCar(Car car)
        {
            _context.Entry(car).State = EntityState.Modified;
        }

        public void DeleteCar(int carID)
        {
            Car car = _context.Cars.Find(carID);
            _context.Cars.Remove(car);
        }

        public IEnumerable<Car> GetAll()
        {
            return _context.Cars.ToList();
        }

        public Car GetById(int carID)
        {
            return _context.Cars.Find(carID);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }



    }
}

