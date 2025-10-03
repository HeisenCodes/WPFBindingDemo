using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Core.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        public partial int Count { get; set; } = 5;

        [RelayCommand]
        private void SetInvalidCount()
        {
            Count = 20;
        }
    }
}
