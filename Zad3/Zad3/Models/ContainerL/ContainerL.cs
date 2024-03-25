namespace Zad3.Models;



public class ContainerL : ContainerBase.ContainerBase
{
    
    
    
    ContainerL(double maxWeight, double baseWeight, double weight, double height, double depth) 
        : base( maxWeight,  baseWeight , weight,  height,  depth)
    {
        Flag = "L";
    }
    
    public override string ToString()
    {
        throw new NotImplementedException();
    }
    
}