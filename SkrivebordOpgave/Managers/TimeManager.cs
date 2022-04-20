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
        public Timer? Timer = new Timer();

        public void SetTimer(int minutes)
        {
            if (minutes > 0)
            {
                int ms = (minutes * 60) * 1000;

                Timer = new Timer();
                Timer.Interval = ms;
                Timer.Elapsed += T_Elapsed;
                Timer.AutoReset = true;

                Timer.Start();

            }

        }

     
        public void T_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

        }

    }
}
