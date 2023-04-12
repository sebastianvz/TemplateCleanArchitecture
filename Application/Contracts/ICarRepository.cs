using System;
using Domain.Entities;

namespace Application.Contracts
{
	public interface ICarRepository : IBaseRepository<Car>
	{
        Car FindbyYead(int? year);
    }
}

