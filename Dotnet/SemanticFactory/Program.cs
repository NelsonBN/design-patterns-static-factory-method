var basic = Membership.CreateBasic();
Console.WriteLine(basic);

var premium = Membership.CreatePremium();
Console.WriteLine(premium);

var executive = Membership.CreateExecutive();
Console.WriteLine(executive);


// Product
public class Membership
{
    public string Level { get; private set; }
    public int Price { get; private set; }

    // Private constructor to control object creation
    private Membership(String level, int price)
    {
        Level = level;
        Price = price;
    }

    // Semantic factory method
    public static Membership CreateBasic()
        => new("Basic", 50);

    // Semantic factory method
    public static Membership CreatePremium()
        => new("Premium", 100);

    // Semantic factory method
    public static Membership CreateExecutive()
        => new("Executive", 150);

    public override string ToString()
        => $"Membership -> Level = {Level}, Price = {Price}";
}
