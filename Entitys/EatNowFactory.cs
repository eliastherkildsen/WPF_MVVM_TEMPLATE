namespace WPF_MVVM_TEMPLATE.Entitys;

public class EatNowFactory
{
    public enum EatNowType
    {
        Pizza,
        Burger
    }
    
    public static Item GenerateItem(EatNowType eatNowType, string itemName, double price)
    {
        switch (eatNowType)
        {
            case EatNowType.Pizza:
                return new Pizza(itemName, price);
            
            case EatNowType.Burger:
                return new Burger(itemName, price);
            
            default:
                throw new ArgumentOutOfRangeException(nameof(eatNowType), eatNowType, null);
        }
        
    }
    
}