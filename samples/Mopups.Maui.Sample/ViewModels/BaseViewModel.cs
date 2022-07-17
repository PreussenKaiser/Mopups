using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Mopups.Maui.Sample.ViewModels;

/// <summary>
/// Represents the base view model.
/// </summary>
public abstract class BaseViewModel
{
    /// <summary>
    /// Handles view changes.
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    /// The pages title.
    /// </summary>
    private string _title;

    /// <summary>
    /// Whether the page is busy or not.
    /// </summary>
    private bool _isBusy;

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseViewModel"/> class.
    /// </summary>
    public BaseViewModel()
    {
        _title = string.Empty;
    }

    /// <summary>
    /// Gets or the pages title.
    /// </summary>
    public string Title
    {
        get => _title;
        protected set => SetProperty(ref _title, value);
    }

    /// <summary>
    /// Gets or whether the page is busy or not.
    /// </summary>
    public bool IsBusy
    {
        get => _isBusy;
        protected set => SetProperty(ref _isBusy, value);
    }

    /// <summary>
    /// Notifies the view that a property has changed.
    /// </summary>
    /// <param name="propertyName">The property which changed.</param>
    protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    /// <summary>
    /// Sets a property and notifies that it has changed.
    /// </summary>
    /// <typeparam name="T">The property's type.</typeparam>
    /// <param name="backingStore">The property's backing field.</param>
    /// <param name="value">The value to set the backing field to.</param>
    /// <param name="propertyName">The property which changed.</param>
    protected virtual void SetProperty<T>(ref T backingStore, T value,
                                          [CallerMemberName] string propertyName = "")
    {
        // Value is the same.
        if (EqualityComparer<T>.Default.Equals(backingStore, value))
            return;

        backingStore = value;

        OnPropertyChanged(propertyName);
    }
}
