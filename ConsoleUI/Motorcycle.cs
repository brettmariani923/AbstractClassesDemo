using System;

public class Motorcycle : Vehicle
{
    public bool HasTwoWheels { get; set; }

    public override string DriveAbstract() 
    {
        return "Its an abstract kind of driving Mannn!";
    }

    public override string DriveVirtual()
    {
        return "Mom, I'm driving in a video game! MOM: Dinner is ready!";
    }
}