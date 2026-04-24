using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Classes
{
    public class Car
    {
        private IEngine _engine;
        private int _speed = 0;

        private int CarStep = 20;
        private int MinSpeed = 0;
        private int MaxSpeed = 200;


        public Car(IEngine engine)
        {
            _engine = engine;
            
        }

        public int GetSpeed()
        {
            return _speed;
        }
        private void NotifyEngine()
        {
             _engine.SetSpeed(_speed);
        }

        public void start()
        {
            _speed = 0;
            _engine.start();
            NotifyEngine();

        }

        public void stop()
        {
            if(_speed != 0)
            {
                return;
            }
            _engine.stop();
        }

        public void Accelerate()
        {
            if(_speed >= MaxSpeed)
            {
                return;
            }
            for(int i = 0; i < CarStep; i++)
            {
                _engine.Accelerate();
            }

            _speed = Math.Min(_speed + CarStep , MaxSpeed);
            NotifyEngine();
        }

        public void Brake()
        {
            if (_speed <= MinSpeed)
            {
               
                return;
            }

            for (int i = 0; i < CarStep; i++)
                _engine.Decrease();

            _speed = Math.Max(_speed - CarStep, MinSpeed);
            NotifyEngine();
             
        }

    }
}
