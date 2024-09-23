using System.Windows;
using WPF_MVVM_TEMPLATE.Presentation.ViewModel;

namespace WPF_MVVM_TEMPLATE.Presentation.View;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = ((App)App.Current);
        
        new RedViewModel(); 
        new BlueViewModel();

    }

    private void ButtonRedClick(object sender, RoutedEventArgs e)
    {
        ((App)App.Current).LoadViewModel(typeof(RedViewModel));
    }
    
    private void ButtonBlueClick(object sender, RoutedEventArgs e)
    {
        ((App)App.Current).LoadViewModel(typeof(BlueViewModel));
    }
    
}