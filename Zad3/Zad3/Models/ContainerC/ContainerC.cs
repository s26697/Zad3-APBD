namespace Zad3.Models.ContainerC;

public class ContainerC : ContainerBase
{

    
    ContainerC(double maxWeight, double baseWeight, double weight, double height, double depth) 
        : base( maxWeight,  baseWeight , weight,  height,  depth)
    {
        Flag = "C";
    }

    public override string ToString()
    {
        throw new NotImplementedException();
    }
}