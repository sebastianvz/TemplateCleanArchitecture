using System;
using Domain.Entities;

namespace Application.Contracts
{
	public interface ICarRepository 
	{
        Car findbyYead(int? year);
    }
}

