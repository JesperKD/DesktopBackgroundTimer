using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SkrivebordOpgave.Managers
{
    public class TimeManager
    {
        public Timer Timer = new Timer();

        public Timer SetTimer(int minutes)
        {
            if (minutes > 0)
            {
                int ms = (minutes * 60) * 1000;

                Timer = new Timer();
                Timer.Interval = ms;
                Timer.AutoReset = true;

                return Timer;
            }
            return null;
        }
    }
}
