namespace Task2Models
{
    public class Programmer : Employee
    {
        public string Name { get; set; }
        public string Role {  get; set; }
        public int HourlyPay { get; set; }
        public Programmer() { }
        public Programmer(string name, int hourlyPay)
        {
            Name = name;
            Role = "Programmer";
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
