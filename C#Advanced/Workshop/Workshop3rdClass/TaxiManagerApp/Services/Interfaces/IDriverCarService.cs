namespace Services.Interfaces
{
    public interface IDriverCarService
    {
        void AssignDriverToCar(int driverId, int carId, int shift);
    }
}
