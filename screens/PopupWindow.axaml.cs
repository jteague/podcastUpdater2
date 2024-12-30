using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace PodcastUpdater2.screens;

public partial class PopupWindow : Window
{
    public PopupWindow()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public void SetContent(Control control)
    {
        // var content = this.FindControl<ContentControl>("ContentArea");
        // if (content != null)
        // {
        //     content.Content = control;
        // }
        ContentArea.Content = control;
    }

    private void Close_Click(object sender, RoutedEventArgs e)
    {
        this.Close(); // Close the modal dialog
    }
}