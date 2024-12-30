using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using ReactiveUI;
using System.Reactive;
using System.Threading.Tasks;

namespace PodcastUpdater2.screens;

public partial class MenuControl : UserControl
{
    public MenuControl()
    {
        InitializeComponent();
        DataContext = new ViewModels.MenuControlViewModel();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}