using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using Microsoft.Windows.Themes;
using WPF_MVVM_TEMPLATE.Presentation.ViewModel;

namespace WPF_MVVM_TEMPLATE.Presentation.View;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application, INotifyPropertyChanged
{

    private ViewModelBase _currentViewModel;
    public ViewModelBase CurrentViewModel
    { 
        get => _currentViewModel; 
        set => SetField(ref _currentViewModel, value); 
    }
    
    private List<KeyValuePair<Type, ViewModelBase>> _viewModels = new List<KeyValuePair<Type, ViewModelBase>>();

    public void AddViewModel(Type type, ViewModelBase viewModel)
    {
        _viewModels.Add(new KeyValuePair<Type, ViewModelBase>(type, viewModel));
        //Debug.WriteLine("Added ViewModel");
    }
    public void LoadViewModel(Type type)
    {
        Debug.WriteLine("Loading ViewModel");
        
        foreach (var viewModel in _viewModels)
        {
            if (viewModel.Key == type)
            {
                CurrentViewModel = viewModel.Value;
                //Debug.WriteLine($"Loaded ViewModel: {viewModel.Key} - {viewModel.Value} ");
            }    
        }
    }

    public List<KeyValuePair<Type, ViewModelBase>> GetViewModels()
    {
        return _viewModels;
    } 

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}