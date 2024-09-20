using System.Diagnostics;

namespace WPF_MVVM_TEMPLATE.Presentation.ViewModel;

public abstract class ViewModelBase
{
    static ViewModelBase()
    {
        Debug.WriteLine(typeof(ViewModelBase).FullName);    
    }
}