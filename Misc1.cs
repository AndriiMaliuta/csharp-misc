namespace chasrp;

public class Misc1
{
    static void Main(string[] args)
    {
        // arrays
        int[] arr = new int[3] { 1, 2, 3 };

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
        
        int[] a1 = new int[10];
        int[,] a2 = new int[10, 5];
        int[,,] a3 = new int[10, 5, 2];
        
        int[] a = new int[10];
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = i * i;
        }
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine($"a[{i}] = {a[i]}");
        }
        
        //
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