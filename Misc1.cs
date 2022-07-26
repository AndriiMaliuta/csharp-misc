namespace chasrp;

public class Misc1
{
    static void Main(string[] args)
    {
        int[] arr = new[] { 1, 2, 3 };

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }

        Point p1 = new Point(1, 2);
        var x1 = p1.X;
        var y1 = p1.Y;
        
        Array.Fill(arr,4);
        
        Console.WriteLine(arr);
        Console.WriteLine(x1);
        Console.WriteLine(y1);
    }
}

public class Point
{
    public int X { get; }
    public int Y { get; }
    
    public Point(int x, int y) => (X, Y) = (x, y);
}