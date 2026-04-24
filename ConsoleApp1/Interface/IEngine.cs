using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Interface
{
    public interface IEngine
    {
        // Car has four operations 
        void start();
        void stop();
        void Accelerate();
        void Decrease();

        ///////////////////////////////////////////////////////////////////////////////

        int GetSpeed();
        void SetSpeed(int speed);
    }
}
