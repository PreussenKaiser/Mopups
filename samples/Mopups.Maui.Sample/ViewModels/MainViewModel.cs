using Mopups.Maui.Sample.Views;

using System.Windows.Input;

namespace Mopups.Maui.Sample.ViewModels;

/// <summary>
/// The view model for <see cref="MainPage"/>.
/// </summary>
public class MainViewModel : BaseViewModel
{
    /// <summary>
    /// The pages counter.
    /// </summary>
    private int _count;

    public MainViewModel()
    {
        _count = 0;

        IncrementCommand = new Command(IncrementCount);
    }

    /// <summary>
    /// Gets the command to execute when the counter is incremented.
    /// </summary>
    public ICommand IncrementCommand { get; }

    /// <summary>
    /// Gets the pages counter.
    /// </summary>
    public int Count
    {
        get => _count;
        private set
        {
            SetProperty(ref _count, value);
            OnPropertyChanged(nameof(CounterText));
        }
    }

    /// <summary>
    /// Gets the text to display the current count.
    /// </summary>
    public string CounterText
        => Count == 1
            ? $"Clicked {Count} time"
            : $"Clicked {Count} times";

    /// <summary>
    /// Increments <see cref="Count"/> by one.
    /// </summary>
    private void IncrementCount()
    {
        Count += 1;
    }
}
