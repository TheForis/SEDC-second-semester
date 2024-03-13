namespace Demo1.Models
{
    public class Trainer : Person
    {
        public int YearsOfExperience { get; set; }

        public override string GetInfo()
        {
            return base.GetInfo() + $" -> Years of experience: {YearsOfExperience}";
        }
    }
}
