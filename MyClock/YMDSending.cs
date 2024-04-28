using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MyClock
{
    delegate void SendDate(string t);
    public partial class Form1 : Form
    {

        SendDate sD;
        YMD ymd;
            private void CountDays()
            {
                sD = new SendDate(SendDays);
                while (true)
                {
                    dT = DateTime.Now;
                    ymd = new YMD(dT);
                    SendDays($"{ymd.D}:{ymd.M}:{ymd.Y}");
                    Thread.Sleep(100000);
                }
            }

            public void SendDays(string text)
            {
                if (label2.InvokeRequired)
                {
                    Invoke(sD, new object[] { text });
                }
                else
                {
                    label2.Text = text;
                }
            }
       
    }
}
