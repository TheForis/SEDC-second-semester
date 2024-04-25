namespace Models
{
    public class Driver : User
    {
        public int DriverLicenceNumber { get; set; }
        public DateTime LicenseExpiryDate { get; set; }
        public Driver(string firstName, string lastName, string username,int driverLicenceNumber, DateTime date) : base(firstName, lastName, username, Role.Driver)
        {
            DriverLicenceNumber = driverLicenceNumber;
            LicenseExpiryDate = date;
        }
        public string GetExpiryDate { get
            {
                return LicenseExpiryDate.ToShortDateString();
            }}
        public void GetDriverInfo()
        {
            Console.WriteLine($"{Role} [{Id}] {FirstName} {LastName}. Licence expires: {GetExpiryDate}.");
        }
    }
}
