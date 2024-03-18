using Demo3.Models;

Console.ForegroundColor = ConsoleColor.Yellow;

#region Method
void RaceCars(Car firstCar, Car secondCar)
{
    if (firstCar.CalculateSpeed(firstCar.Driver) > secondCar.CalculateSpeed(secondCar.Driver))
    {
        Console.WriteLine($"In the race the winner car was {firstCar.Model}. It was driving with {firstCar.Speed} km/h and the driver was {firstCar.Driver.Name} !");
        return;
    }
    else if(firstCar.CalculateSpeed(firstCar.Driver) < secondCar.CalculateSpeed(secondCar.Driver))
    {
        Console.WriteLine($"In the race the winner car was {secondCar.Model}. It was driving with {secondCar.Speed} km/h and the driver was {secondCar.Driver.Name} !");
        return ;

    }
    Console.WriteLine("They are equal");
}

#endregion

#region Data

Driver d1 = new Driver("Verstappen",5);
Driver d2 = new Driver("Hamilon", 4);
Driver d3 = new Driver("Leclerc", 4);
Driver d4 = new Driver("Perez",3);

Car c1 = new Car("Mercedes", 320);
Car c2 = new Car("Red Bull", 380);
Car c3 = new Car("Ferrari", 290);
Car c4 = new Car("Renault", 40);


Driver[] drivers = new Driver[] {d1,d2,d3,d4};
Car[] cars = new Car[] { c1, c2, c3, c4 };

bool endGame = false;

#endregion


do
{
    Console.WriteLine($"Please select the first car: \n no.1 {c1.Model} \n no2. {c2.Model} \n no3. {c3.Model} \n no4. {c4.Model}");
    bool canParseFirstCar = int.TryParse(Console.ReadLine(), out int firstCar);

    Console.WriteLine($"Please select the second car: \n no.1 {c1.Model} \n no2. {c2.Model} \n no3. {c3.Model} \n no4. {c4.Model}");
    bool canParseSecondCar = int.TryParse(Console.ReadLine(), out int secondCar);

    Console.WriteLine($"Please select the first driver: \n no.1 {d1.Name} \n no2. {d2.Name} \n no3. {d3.Name} \n no4. {d4.Name}");
    bool canParseFirstDriver = int.TryParse(Console.ReadLine(), out int firstDriver);

    Console.WriteLine($"Please select the second driver: \n no.1 {d1.Name} \n no2. {d2.Name} \n no3. {d3.Name} \n no4. {d4.Name}");
    bool canParseSecondDriver = int.TryParse(Console.ReadLine(), out int secondDriver);

    if(canParseFirstCar && canParseSecondCar && canParseFirstDriver && canParseSecondDriver)
    {
        Car firstSelectedCar = cars[firstCar - 1];
        Car secondSelectedCar = cars[secondCar - 1];

        Driver firstSelectedDriver = drivers[firstDriver -1];
        Driver secondSelectedDriver = drivers[secondDriver - 1];

        firstSelectedCar.Driver = firstSelectedDriver;
        secondSelectedCar.Driver = secondSelectedDriver;

        RaceCars(firstSelectedCar, secondSelectedCar);

        Console.WriteLine(" Do you want to play again? If not please enter N otherwise enter Y!");
        string userInput = Console.ReadLine();
        if (userInput.ToLower() == "n")
        {
            endGame = false;
        }


    }
    else
    {
        Console.WriteLine("Wrong input. Please select using numbers from 1-4");
        endGame = true;

    }

}while(endGame);