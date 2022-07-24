using Mopups.Sample.CSharpMarkup;

namespace Mopups.Sample;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new MainPage());
    }
}
