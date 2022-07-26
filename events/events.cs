using chasrp.inherit;

namespace chasrp.events;

public class events
{
    
}

class EventExample
{
    static int s_changeCount;
    
    static void ListChanged(object sender, EventArgs e)
    {
        s_changeCount++;
    }
    
    public static void Usage()
    {
        var names = new MyList<string>();
        names.Changed += new EventHandler(ListChanged);
        names.Add("Liz");
        names.Add("Martha");
        names.Add("Beth");
        Console.WriteLine(s_changeCount); // "3"
        
        // operators
        MyList<int> a = new();
        a.Add(1);
        a.Add(2);
        MyList<int> b = new();
        b.Add(1);
        b.Add(2);
        Console.WriteLine(a == b);  // Outputs "True"
        b.Add(3);
        Console.WriteLine(a == b);  // Outputs "False"
    }
}