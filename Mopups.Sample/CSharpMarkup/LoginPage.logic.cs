using Mopups.Pages;

namespace Mopups.Sample.CSharpMarkup;

public partial class LoginPage : PopupPage
{
    public LoginPage()
    {
        BuildContent();
    }

    protected override bool OnBackgroundClicked()
    {
        return base.OnBackgroundClicked();
    }
}
