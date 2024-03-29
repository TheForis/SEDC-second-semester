namespace Task2Models
{
    public class Manager : Employee
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public int HourlyPay { get; set; }
        public Manager() { }
        public Manager(string name,int hourlyPay)
        {
            Name = name;
            Role = "Manager";
            HourlyPay = hourlyPay;

        }
        public override int CalculateSalary(int workingDays)
        {
            return (HourlyPay * 8) * workingDays;
        }

        public override string GetInfo()
        {
            return $"The employee with name: {Name} is working as {Role} at the company";
        }
    }
}
