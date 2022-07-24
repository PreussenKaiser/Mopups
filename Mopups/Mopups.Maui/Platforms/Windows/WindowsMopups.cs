using Mopups.Interfaces;
using Mopups.Pages;

namespace Mopups.Windows.Implementation;

public class WindowsMopups : IPopupPlatform
{
    public Task AddAsync(PopupPage page)
    {
        throw new NotImplementedException();
    }

    public Task RemoveAsync(PopupPage page)
    {
        throw new NotImplementedException();
    }
}
