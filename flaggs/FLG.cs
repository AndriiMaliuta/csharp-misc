namespace chasrp.flaggs;

public class FLG
{
    void Enums()
    {
        var spring = Seasons.Spring;
        var startingOnEquinox = Seasons.Spring | Seasons.Autumn;
        var theYear = Seasons.All;
        
        int? optionalInt = default; 
        optionalInt = 5;
        string? optionalText = default;
        optionalText = "Hello World.";
        
        // tuples
        (double Sum, int Count) t2 = (4.5, 3);
        Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
    }
}

[Flags]
public enum Seasons
{
    None = 0,
    Summer = 1,
    Autumn = 2,
    Winter = 4,
    Spring = 8,
    All = Summer | Autumn | Winter | Spring
}

public class Color
{
    public static readonly Color Black = new(0, 0, 0);
    public static readonly Color White = new(255, 255, 255);
    public static readonly Color Red = new(255, 0, 0);
    public static readonly Color Green = new(0, 255, 0);
    public static readonly Color Blue = new(0, 0, 255);
    
    public byte R;
    public byte G;
    public byte B;

    public Color(byte r, byte g, byte b)
    {
        R = r;
        G = g;
        B = b;
        
        
    }
    
    public override string ToString() => "This is an object";
}