namespace Services
{
    public class ActiveTraining
    {
        private int _counter;

        public ActiveTraining()
        {
            _counter = 0;
        }

        private void Train()
        {
            _counter++;
            switch (_counter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);

        }
        public void TrainNow()
        {
            Console.WriteLine("Training...");
            while (true)
            {
                Train();
                System.Threading.Thread.Sleep(50);
                if (_counter % 50 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Training Complete!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
            }
        }
    }
}
