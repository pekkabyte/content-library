using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;

namespace content_library.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    string text = "";

    [RelayCommand]
    void Toggle()
    {

    }
}