using task1.Models;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = CarsData.Cars;
            Console.WriteLine($"There are total of: {cars.Count} Cars.");
            var europeanOriginCars = cars.Where(x=> x.Origin == "Europe").ToList();
            //Console.WriteLine($"\n1)Cars from european origin: {europeanOriginCars.Count}\n");
            //PrintCars(europeanOriginCars);


            var carsWithMoreThan6Cyl = cars.Where(x=> x.Cylinders > 6).ToList();
            var fourCylCarsWithMoreHp = cars.Where(x=> x.Cylinders == 4 && x.HorsePower >= 110).ToList();
            var joinedCarList = carsWithMoreThan6Cyl.Union(fourCylCarsWithMoreHp).ToList();
            //Console.WriteLine($"\n2) Cyl > 6 & Cyl = 4 && hp>110\n");
            //PrintCars(joinedCarList );

            
            //var groupedOrigins = cars.GroupBy(x => x.Origin).ToList();
            //foreach(var item in groupedOrigins) {
            //    Console.WriteLine($"Orgin: {item.Key} - {item.Count()} cars!");
            //        }

            var carsWithALotHp = cars.Where(x=> x.HorsePower > 200).Select(x=> x.MilesPerGalon).ToList();
            var minMpg = carsWithALotHp.Min();
            var maxMpg = carsWithALotHp.Max();
            var avgMpg = carsWithALotHp.Average();
            //Console.WriteLine($"MPG ON CARS OVER 200HP \nMin MPG: {minMpg}  -  Max MPG: {maxMpg}   -  Avg MPG: {avgMpg}");

            //Ova e ko narednoto baranje. Prvo go napraiv ova pa prochitav deka treba 3 da se isprintaat. (samo vrakja celi informacii a ne model...
            var fastestCars = cars.OrderBy(x=> x.AccelerationTime).Take(3).ToList();
            //PrintCars(fastestCars);

            var weightOfVehicles = cars.Where(x=>x.Cylinders > 6).Select(x=> x.Weight).Sum();
            //Console.WriteLine($"Total weight of Cars with more than 6 Cylinders: {weightOfVehicles}kg.");

            var avgMpgEvenCyl = cars.Where(x=> x.Cylinders % 2 == 0).Select(x => x.MilesPerGalon).Average();
            Console.WriteLine($"The average MPG for even cylinder cars: {avgMpgEvenCyl}");
            




            ////////Probuvav bez linq dali e tochno linq-to - :)
            //////Dictionary<string, int> originCounter = new Dictionary<string, int>();
            //////foreach (Car item in cars)
            //////{
            //////    if (originCounter.ContainsKey(item.Origin))
            //////    {
            //////        originCounter[item.Origin]++;
            //////    }
            //////    else
            //////    {
            //////        originCounter.Add(item.Origin, 1);
            //////    }
            //////}
            //////foreach (var item in originCounter)
            //////{
            //////    Console.WriteLine($"Origin: {item.Key} - {item.Value} cars!");
            //////}

        }
        static void PrintCars (List<Car> cars)
        {
            foreach (Car item in cars)
            {
                Console.WriteLine($"Model: {item.Model};  Origin: {item.Origin};  Weight: {item.Weight}kg.;  No.of Cyl: {item.Cylinders};  HP: {item.HorsePower};  MPG: {item.MilesPerGalon};  Acceleration to 100Km/h: {item.AccelerationTime} seconds.");
            }
        }
    }
}
