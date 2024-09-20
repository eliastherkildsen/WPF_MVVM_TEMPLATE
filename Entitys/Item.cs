namespace WPF_MVVM_TEMPLATE.Entitys;

public abstract class Item
{
    
    protected string _name;
    protected double _price;

    protected Item(string name, double price)
    {
        _name = name;
        _price = price;
    }
    
}