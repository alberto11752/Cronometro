using System;
using System.Windows.Controls;

namespace CronometroDosBotones.Interfaces
{
    public interface ILabelUpdater
    {
        public void RefreshLabel();
        public void RefreshLabel(Object stateInfo);
        public void ConfigTimer();
        public void PauseRefresh();
        public void StartRefresh();
    }
}
