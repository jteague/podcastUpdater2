using System;
using Avalonia.Controls;

namespace PodcastUpdater2;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        this.Opened += MainWindow_Opened;
    }

    private void MainWindow_Opened(object? sender, EventArgs e)
    {
        CenterAppOnScreen();
    }

    private void CenterAppOnScreen()
    {
        var screen = Screens.Primary;
        if (screen == null)
        {
            return;
        }
        
        var width = (int)DesiredSize.Width / 2;
        var height = (int)DesiredSize.Height / 2;
        int x = screen.Bounds.Width / 2 - width;
        int y = screen.Bounds.Height / 2 - height;
        Position = new Avalonia.PixelPoint(x, y);
    }
}