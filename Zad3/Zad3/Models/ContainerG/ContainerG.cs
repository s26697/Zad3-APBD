namespace Zad3.Models;

public class ContainerG : ContainerBase
{

     
    ContainerG(double maxWeight, double baseWeight, double weight, double height, double depth) 
        : base( maxWeight,  baseWeight , weight,  height,  depth) 
    {
        Flag = "G";
    }
    public override string ToString()
    {
        throw new NotImplementedException();
    }   
}