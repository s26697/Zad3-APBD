using System.Collections;


namespace Zad3.Models.Ship;

public class Ship
{
    public List<ContainerBase.ContainerBase> CargoList;  
    
    protected double Speed { get; set; }

    protected int MaxContainerCount { get; set; }
    
    protected double MaxContainerWeight { get; set; }

    internal Ship(double speed, int maxContainerCount, double maxContainerWeight)
    {
        Speed = speed;

        MaxContainerCount = maxContainerCount;

        MaxContainerWeight = maxContainerWeight;

        CargoList = new List<ContainerBase.ContainerBase>();
    }


    public static void LoadContainerList()
    {
        //##todo
    }
    

    public static void UnloadContaine()
    {
        //##todo
    }

    public static void LoadContainer()
    {
        //##todo
    }
    
    public override string ToString()
    {
        
        //##TODO
        return "";
    }
    
    
}