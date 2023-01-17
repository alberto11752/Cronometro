using CronometroTresBotones.Interfaces;

namespace CronometroTresBotones
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
