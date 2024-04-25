namespace Models
{
    public class Car : BaseEntity
    {
        public string Model { get; set; }
        public int LicensePlate { get; set; }
        public DateTime LicensePlateExpieryDate { get; set; }
        public Dictionary<Shift, Driver> AssignedDrivers { get; set;}
    }
}
