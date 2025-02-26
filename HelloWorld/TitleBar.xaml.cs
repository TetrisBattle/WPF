using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace HelloWorld
{
    public partial class TitleBar : UserControl
    {
        public TitleBar()
        {
            InitializeComponent();

            // Mahdollistaa yläpalkin raahaamisen
            MouseDown += (s, e) =>
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    Window.GetWindow(this)?.DragMove();
                }
            };
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this)?.Close();
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this);
            if (window != null) window.WindowState = WindowState.Minimized;
        }

        private void MaximizeRestore_Click(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this);
            if (window != null)
            {
                window.WindowState = window.WindowState == WindowState.Maximized ?
                                     WindowState.Normal : WindowState.Maximized;
            }
        }
    }
}
