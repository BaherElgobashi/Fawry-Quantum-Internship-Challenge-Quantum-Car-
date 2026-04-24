using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Engine
{
    public class ElectricEngine : IEngine
    {
        private int _speed = 0;

        public void start()
        {
            _speed = 0;
        }

        public void stop()
        {
            _speed = 0;
        }
        public void Accelerate()
        {
            _speed += 1;
        }

        public void Decrease()
        {
            if(_speed > 0)
            {
                _speed -= 1;
            }
        }

        public int GetSpeed()
        {
            return _speed;
        }

        public void SetSpeed(int speed)
        {
            _speed = speed;
        }

        
    }
}
