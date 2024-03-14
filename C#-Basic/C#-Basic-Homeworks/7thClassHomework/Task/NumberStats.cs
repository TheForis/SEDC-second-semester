namespace Task
{
    public class NumberStats
    {
        public decimal Number { get; set; }

        public NumberStats (decimal number) 
        {
            Number = number;
        }
        public string IsPositive { get
            {
                if (Number >= 0)
                {
                    return "Positive";
                }
                return "Negative";
            }
        }
        public string IsInteger { get
            {
                if(Number % 1 == 0)
                {
                    return "Integer";
                }
                return "Decimal";
            } }
        public string IsEven { get
            {
                if (Number % 2 == 0)
                {
                    return "Even";

                }
                return "Odd";
            } }
        public string GetNumberStats()
        {
            return $"Stats for number: {Number} \n * {IsPositive} \n * {IsInteger} \n * {IsEven}";
        }
    }   
}
