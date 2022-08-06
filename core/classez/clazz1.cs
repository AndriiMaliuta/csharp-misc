
namespace Classez
{
    record Point
    {
        public Point(double x, double y) => (X, Y) = (x, y);
        public double X { get; init; }
        public double Y { get; init; }
    }
    class Foo
    {
        public int ID { get; init; }

        void init()
        {
            var foo1 = new Foo { ID = 43 };
            Point p1 = new Point(1, 2);
            Point p2 = p1 with { Y = 4 };

        }
        bool IsVowel(char c) => c is 'a' or 'e' or 'i' or 'o' or 'u';
        string cardName = cardNumber switch // assuming cardNumber is an int
        {
            13 => "King",
            12 => "Queen",
            11 => "Jack",
            _ => "Pip card" // equivalent to 'default'
        };
    }
}
