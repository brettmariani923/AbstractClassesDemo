
using System;
using System.Collections.Generic;

public abstract class Vehicle
{
    public int Year { get; set; }

    public string Make { get; set; }

    public string Model { get; set; }

    public abstract string DriveAbstract();
    public virtual string DriveVirtual()
    {
        return "Driving Cars is really fun! ESPECIALLY IN 3D!";
    }
}