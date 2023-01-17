using System;
using System.Windows.Controls;
using System.Diagnostics;
using System.Windows;
using System.Threading;
using CronometroDosBotones.Interfaces;

namespace CronometroDosBotones
{
    public class Cronometro : CronometroBase, ICronometro
    {
        public void Start()
        {
            base.Status = CStatus.Running;
            base.Stopwatch.Start();
        }

        public void Pause()
        {
            base.Status = CStatus.Paused;
            base.Stopwatch.Stop();
        }

        public void Stop()
        {
            base.Status=CStatus.Stopped;
            base.Stopwatch.Reset();
        }
    }
}
