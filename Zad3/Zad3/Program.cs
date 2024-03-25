using Zad3.Models;
using Zad3.Models.ContainerBase;
using 
using Zad3.Models.ContainerC;
using Zad3.Models.Ship;

class Program()
{
    public static void Main(String[] args)
    {
        
        Ship ship = new Ship(20, 100, 50000); 
        ContainerBase container1 = new ContainerC(50000, 2000, 30000, 200, 150); 
        ContainerBase container2 = new ContainerG(60000, 2500, 35000, 220, 160);
       // ship.LoadContainerList(new List<ContainerBase> { container1, container2 });
    }
}