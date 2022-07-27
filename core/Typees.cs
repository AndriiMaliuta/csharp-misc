namespace csharp_misc.core
{
    public class Typees
    {
        public void TypesOne() 
        {
            // Declaration only:
            float temperature;
            string name;

            // Declaration with initializers (four examples):
            char firstLetter = 'C';
            var limit = 3;
            int[] source = { 0, 1, 2, 3, 4, 5 };
            var query = from item in source
                        where item <= limit
                        select item;
        }

        public string GetName(int ID)
        {
            if (ID < names.Length)
                return names[ID];
            else
                return String.Empty;
        }
        private string[] names = { "Spencer", "Sally", "Doug" };
    }
}