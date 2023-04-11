using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Car 
{
    public int IdCar { get; set; }

    public string? Name { get; set; }

    public int? Year { get; set; }

    public string? Model { get; set; }

    public float? Price { get; set; }

    public string? Brand { get; set; }

}
