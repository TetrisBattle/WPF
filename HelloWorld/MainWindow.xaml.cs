using System.Windows;
using HelloWorld.Pages;
using MahApps.Metro.Controls;

namespace HelloWorld;

public partial class MainWindow : MetroWindow
{
    public MainWindow()
    {
        InitializeComponent();
        MainFrame.Navigate(new HomePage());
    }
}