namespace Services.Interfaces
{
    public interface ICarService
    {
        void CreateCar(string licencePlate, DateTime licencePlateexpiryDate, string model);
    }
}
