using System.Windows.Controls;
using System.Windows;
using Utilities.Interfaces;
using System.Diagnostics;

namespace Utilities
{
    public class LabelUpdater : ILabelUpdater
    {
        private Timer _timer;
        private Label _label;
        private int _miliseconds;
        private Stopwatch _stopwatch;

        public LabelUpdater(ref Label label,ref Stopwatch stopwatch, int miliseconds)
        {
            _label = label;
            _miliseconds = miliseconds;
            _stopwatch = stopwatch;
            ConfigTimer();
        }

        public void RefreshLabel(object stateInfo)
        {
            RefreshLabel();
        }

        public void ConfigTimer()
        {
            _timer = new Timer(RefreshLabel, new AutoResetEvent(true), 0, _miliseconds);
        }


        public void RefreshLabel()
        {
            if (Application.Current != null)//Evita error si se cierra la aplicacion mientras inten  ta actualizar el label
            {
                //Evita error si el label esta siendo utilizado en otro hilo
                Application.Current.Dispatcher.Invoke(() =>
                {
                    _label.Content = string.Format("{0:D2}:{1:D2}:{2:D2}",
                               _stopwatch.Elapsed.Hours,
                               _stopwatch.Elapsed.Minutes,
                               _stopwatch.Elapsed.Seconds);
                });
            }
        }

        public void PauseRefresh()
        {
            RefreshLabel();
            _timer.Change(Timeout.Infinite, Timeout.Infinite);
        }

        public void StartRefresh()
        {
            RefreshLabel();
            ConfigTimer();
        }
    }
}
