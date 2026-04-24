using ConsoleApp1.Classes;
using ConsoleApp1.Enums;
using ConsoleApp1.CarFactory;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleApp1.CarFactory.CarFactory factory = new ConsoleApp1.CarFactory.CarFactory();

            ////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////////// ");
            Car gasCar = factory.CreateCar(EngineType.GasEngine);
            gasCar.start();
            gasCar.Accelerate();   
            gasCar.Accelerate();  
            gasCar.Brake();        
            gasCar.Brake();        
            gasCar.stop();
            Console.WriteLine($"The type of Engine is {EngineType.GasEngine}");


            ////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////////// ");
            Car electricCar = factory.CreateCar(EngineType.ElectricEngine);
            electricCar.start();
            electricCar.Accelerate();   
            electricCar.Accelerate();   
            electricCar.stop();         
            electricCar.Brake();        
            electricCar.Brake();        
            electricCar.stop();
            Console.WriteLine($"The type of Engine is {EngineType.ElectricEngine}");

            ////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////////// ");


            
            Car hybridCar = factory.CreateCar(EngineType.HybridEngine);
            hybridCar.start();
            hybridCar.Accelerate();   
            hybridCar.Accelerate();   
            hybridCar.Accelerate();   
            hybridCar.Brake();        
            hybridCar.Brake();        
            hybridCar.Brake();        
            hybridCar.stop();
            Console.WriteLine($"The type of Engine is {EngineType.HybridEngine}");
            ////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////////// ");

            
            factory.ReplaceEngine(gasCar, EngineType.HybridEngine);
            gasCar.start();
            gasCar.Accelerate();
            gasCar.Brake();
            gasCar.stop();
        }
    }
}
