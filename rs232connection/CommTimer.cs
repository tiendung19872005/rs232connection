using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace rs232connection
{
    class CommTimer
    {
        public Timer tmrComn = new Timer();
        public bool timedout = false;
        public CommTimer()
        {
            timedout = false;
            tmrComn.AutoReset = false;
            tmrComn.Enabled = false;
            tmrComn.Interval = 1000; // 1giay
            tmrComn.Elapsed += new ElapsedEventHandler(tmrComn_Elapsed);
        
        }

        void tmrComn_Elapsed(object sender, ElapsedEventArgs e)
        {

            timedout = true;
            tmrComn.Stop();
        }
        public void Start(double timeoutperiod)
        {
            tmrComn.Interval = timeoutperiod;
            tmrComn.Stop();
            timedout = false;
            tmrComn.Start();
        }

    }
}
