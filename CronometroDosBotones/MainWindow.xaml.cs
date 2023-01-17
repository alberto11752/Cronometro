﻿using System.Windows;
using System.Windows.Media;
using Utilities;

namespace CronometroDosBotones
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
            _labelUpdater = new LabelUpdater(ref lbl_Timer,ref _cronometro.Stopwatch, 500);
            btn_Pause.IsEnabled = false;
        }

        private void btn_StartStop_Click(object sender, RoutedEventArgs e)
        {
            if (_cronometro.Status != CronometroBase.CStatus.Stopped)
            {
                btn_StartStop.Content = "Start";
                btn_StartStop.Background = Brushes.Green;
                btn_Pause.Content = "Pause";
                _cronometro.Stop();
                _labelUpdater.PauseRefresh();
                btn_Pause.IsEnabled = false;

            }
            else
            {
                btn_StartStop.Content = "Stop";
                btn_StartStop.Background = Brushes.Red;
                _labelUpdater.StartRefresh();
                _cronometro.Start();
                btn_Pause.IsEnabled = true;    
            }
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
