using Mopups.Maui.Sample.ViewModels;

namespace Mopups.Maui.Sample.Views;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}

