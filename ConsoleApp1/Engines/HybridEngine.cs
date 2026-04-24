using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Engine
{
    public class HybridEngine : IEngine
    {

        private readonly GasEngine gasEngine = new GasEngine();
        private readonly ElectricEngine electricEngine = new ElectricEngine();

        private IEngine _activeEngine;
        private int _speed = 0;

        private const int ChangeTheEngine = 50;

        public HybridEngine()
        {
            // as the Engine which should be Switched to is the Electric Engine.
            _activeEngine = electricEngine;
        }

        private void ChangeIfNeeded(int CarSpeed)
        {
            IEngine Target;
            if(_speed < 50)
            {
                Target = electricEngine;
            }
            else
            {
                Target = gasEngine;
            }
            if(Target == _activeEngine)
            {
                return;
            }


            _activeEngine.stop();
            _activeEngine = Target;
            _activeEngine.start();
            _activeEngine.SetSpeed(CarSpeed);
        }



        public void start()
        {
            _speed = 0;
            _activeEngine = electricEngine;
            _activeEngine.start();
        }

        public void stop()
        {
            _speed = 0;
            _activeEngine = electricEngine;
            _activeEngine.stop();

        }
        public void Accelerate()
        {
            _speed = _speed + 1;
        }

        public void Decrease()
        {
            if(_speed > 0)
            {
                _speed--;
            }
        }

        public int GetSpeed()
        {
            return _speed;
        }

        public void SetSpeed(int Carspeed)
        {
            _speed = Carspeed;
            ChangeIfNeeded(Carspeed);
            _activeEngine.SetSpeed(Carspeed);
        }

        
    }
}
