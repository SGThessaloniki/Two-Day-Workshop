using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithCS
{
    class Car
    {
        public int Speed { get; set; }

        public void Accelerate()
        {
            Speed += 10;
            if(Speed > 120)
            {
                //raise the event
                if (CarSpeedLimitReached != null)
                    CarSpeedLimitReached("BOOM");
            }
        }

        public Car() { Speed = 20; }

        public event CarSpeedLimitReachedHandler CarSpeedLimitReached;

    }
    public delegate void CarSpeedLimitReachedHandler (string msg);
}
