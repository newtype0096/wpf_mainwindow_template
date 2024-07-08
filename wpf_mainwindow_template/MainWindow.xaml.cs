using System;
using System.Windows;

namespace wpf_mainwindow_template
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_StateChanged(object sender, EventArgs e)
        {
            SetCaptionHeight();
        }

        private void TitleBar_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            SetCaptionHeight();
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Maximize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Maximized;
        }

        private void Restore_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Normal;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SetCaptionHeight()
        {
            switch (WindowState)
            {
                case WindowState.Normal:
                    Chrome.CaptionHeight = TitleBar.ActualHeight + BorderThickness.Top - Chrome.ResizeBorderThickness.Top;
                    break;

                case WindowState.Maximized:
                    Chrome.CaptionHeight = TitleBar.ActualHeight - BorderThickness.Top;
                    break;
            }
        }
    }
}