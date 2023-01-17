using System.Diagnostics;

namespace CronometroDosBotones
{
    public class CronometroBase
    {
        public CStatus Status = CStatus.Stopped;
        public Stopwatch Stopwatch = new Stopwatch();

        public enum CStatus
        {
            Paused=0,
            Stopped=1,
            Running=2
        }
    }
}
