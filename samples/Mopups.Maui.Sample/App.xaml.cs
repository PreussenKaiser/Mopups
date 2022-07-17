using Mopups.Maui.Sample.Views;

namespace Mopups.Maui.Sample;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }
}
