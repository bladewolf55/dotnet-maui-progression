using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace Maui.Progression.ViewModels;

public partial class Counter : ObservableObject
{
    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(CountText))]
    int count;

    public string CountText
    {
        get
        {
            string text = "Click me";
            if (count > 0)
            {
                text = $"Clicked {count} " + (count == 1 ? "time" : "times");
            }            
            SemanticScreenReader.Announce(text);
            return text;
        }
    }

    [ICommand]
    void IncreaseCounter()
    {
        Count++;
    }
}

