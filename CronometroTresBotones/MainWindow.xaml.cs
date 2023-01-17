using System.Windows;
using Utilities;

namespace CronometroTresBotones
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Cronometro _cronometro;
        LabelUpdater _labelUpdater;
        public MainWindow()
        {
            InitializeComponent();
            _cronometro = new Cronometro();
            _labelUpdater = new LabelUpdater(ref lbl_Timer, ref _cronometro.Stopwatch, 500);
            btn_Pause.IsEnabled = false;
            btn_Stop.IsEnabled = false;
        }

        private void btn_Start_Click(object sender, RoutedEventArgs e)
        {
            _labelUpdater.StartRefresh();
            _cronometro.Start();
            btn_Pause.IsEnabled = true;
            btn_Start.IsEnabled = false;
            btn_Stop.IsEnabled = true;
        }
        private void btn_Stop_Click(object sender, RoutedEventArgs e)
        {
            btn_Pause.Content = "Pause";
            _cronometro.Stop();
            _labelUpdater.PauseRefresh();
            btn_Pause.IsEnabled = false;
            btn_Start.IsEnabled = true;
            btn_Stop.IsEnabled = false;

        }

        private void btn_Pause_Click(object sender, RoutedEventArgs e)
        {
            if (_cronometro.Status == CronometroBase.CStatus.Running)
            {
                btn_Pause.Content = "Continue";
                _labelUpdater.PauseRefresh();
                _cronometro.Pause();
            }
            else
            {
                btn_Pause.Content = "Pause";
                _labelUpdater.StartRefresh();
                _cronometro.Start();
            }
        }
    }
}
