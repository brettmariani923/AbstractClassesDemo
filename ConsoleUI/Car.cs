using System;

public class Car : Vehicle
{   
    public bool HasFourDoors { get; set; }

   public override string DriveAbstract()
    {
        return "Wahooo! I'm driving in abstraction!";
    }
}