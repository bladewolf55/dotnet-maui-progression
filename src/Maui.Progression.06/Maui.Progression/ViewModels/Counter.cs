using Maui.Progression.Domain.Models;
using Maui.Progression.DomainServices;
using Maui.Progression.DomainServices.Interfaces;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace Maui.Progression.ViewModels;

public partial class Counter : ObservableObject
{
    readonly INumberMapper numberMapperService;
    readonly NumberMap map = new();

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(CountText))]
    int count;

    public Counter(INumberMapper numberMapper) { 
        this.numberMapperService = numberMapper ?? new NumberMapper();
        map = numberMapperService.GetNumberMap();
    }

    public string CountText
    {
        get
        {
            string text = "Click me";
            if (count > 0)
            {
                var word = map.ToWord(count) ?? "Unknown";
                text = $"Clicked {word} " + (count == 1 ? "time" : "times");
            }
            // SemanticScreenReader.Announce(text);
            return text;
        }
    }

    [ICommand]
    void IncreaseCounter()
    {
        Count++;
    }
}

