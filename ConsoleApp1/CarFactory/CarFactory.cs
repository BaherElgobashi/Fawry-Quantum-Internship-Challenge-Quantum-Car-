using ConsoleApp1.Classes;
using ConsoleApp1.Engine;
using ConsoleApp1.Enums;
using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CarFactory
{
    
        public class CarFactory
        {
            public Car CreateCar(EngineType type)
            {
                IEngine engine = BuildEngine(type);
                Console.WriteLine($"Factory created car with: {engine.GetType().Name}");
                return new Car(engine);
            }

            public void ReplaceEngine(Car car, EngineType type)
            {
                IEngine engine = BuildEngine(type);
                car.SetEngine(engine);
            }

            private IEngine BuildEngine(EngineType type)
            {
                if (type == EngineType.GasEngine)
                {
                    return new GasEngine();
                }
                else if (type == EngineType.ElectricEngine)
                {
                    return new ElectricEngine();
                }
                else if (type == EngineType.HybridEngine)
                {
                    return new HybridEngine();
                }
                else
                {
                    throw new ArgumentException("Invalid engine type");
                }

            }
        }
    }

