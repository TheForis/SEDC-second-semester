namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For LOOP

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Iteration no: {i+1}");
            }

            int j;

            for (j = 10;j>0;j--)
            {
                Console.WriteLine($"Number:{j}");
            }

            int k = 10;
            for (; k > 0; k--)
            {
                Console.WriteLine(k);
            }
            #endregion

            int start = 90;

            while (true)
            {
                Console.WriteLine(start);
                start++;
                
                if (start > 550)
                {
                    break;
                }
            }


            int z = 50;

            do
            {
                Console.WriteLine(z);
                z--;
            }
            while (z >= 0);


        }
    }
}
