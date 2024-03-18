namespace Zad3.Models;

public abstract class ContainerBase
{
    
    public double MaxWeight { get;  }
    
    protected double Weight { get; private set; }
    
    protected double BaseWeight { get; set; }
    
    protected double Height { get; set; }
    
    protected double Depth { get; set; }
    
    protected string SerialNumber { get; set; }

    protected string Flag;
    
    
    protected ContainerBase(double maxWeight, double baseWeight, double weight, double height, double depth)
    {
        MaxWeight = maxWeight;

        BaseWeight = baseWeight;

        Weight = weight;

        Height = height;

        Depth = depth;

        Flag = "B";
        
        SerialNumber = GetSerial();


        
    }

    protected void SetWeight(double weight)
    {
        if (weight > MaxWeight)
        {
            throw new ArgumentException("Przekroczono maksymalna " +
                                        "wage kontenera");
        }

        Weight = weight;
    }

    protected string GetSerial()
    {
         
        
        
        
        return ("KON-" + Flag + "-" + Getid);
    }

    private int Getid()
    {
        return 1; // ##TODO 
    }

    public abstract override string ToString();

}