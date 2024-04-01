namespace ModelsDemo1
{
    public class ListHelper
    {
        public static void PrintItems<T>(List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
        public static void PrintUserItem<T>(List<T> items) where T : User
        {
            foreach (T item in items)
            {
                Console.WriteLine(item.GetFullName);
            }
        }
    }
}
