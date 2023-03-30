using System;
using Microsoft.EntityFrameworkCore;
using Application.Contracts;
using Domain.Entities;
using Infrastructure.EntityModeles;

namespace Infrastructure.DataBase.Repositorys
{ 
    public class CarRepository : BaseRespository<Car> , ICarRepository
    {
        private readonly TestUpbContext _context;

        public CarRepository(TestUpbContext context):base(context)
        {
            _context = context;
        }

        public Car findbyYead(int? year)
        {
            return _context.Cars.Where(c => c.Year == year).FirstOrDefault();

        }
        
    }
}

