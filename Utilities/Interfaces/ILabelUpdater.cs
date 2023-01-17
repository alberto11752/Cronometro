namespace Utilities.Interfaces
{
    public interface ILabelUpdater
    {
        public void RefreshLabel();
        public void RefreshLabel(object stateInfo);
        public void ConfigTimer();
        public void PauseRefresh();
        public void StartRefresh();
    }
}
