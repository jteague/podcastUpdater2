using System.Threading.Tasks;
using System.Windows.Input;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using PodcastUpdater2.screens;
using ReactiveUI;

namespace PodcastUpdater2.ViewModels;

public class MenuControlViewModel
{
    public ICommand OpenSettingsCommand { get; }

    public MenuControlViewModel()
    {
        OpenSettingsCommand = ReactiveCommand.CreateFromTask(OpenSettings);
    }

    private async Task OpenSettings()
    {
        var popup = new PopupWindow();
        popup.SetContent(new Settings());
        if (Application.Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop &&
            desktop?.MainWindow != null)
        {
            await popup.ShowDialog(desktop.MainWindow);
        }
    }
}
