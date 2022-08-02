using PowerLine.Maksim.Kulebyakin.Test.Task;


PassengerCar car = new PassengerCar(4, 4, 25, 630.0, 25.0, 200.0);

Console.WriteLine(car.NameOfType);

Console.WriteLine(car.GetFullKilometers());

car.DisplayCurrentFuelRange();

car.GetDistance(630, 25);

Console.WriteLine("-----------");

Auto auto = new Auto(25.0, 650.0, 25.0, 200.0);

Console.WriteLine(auto.NameOfType);

Console.WriteLine(auto.GetFullKilometers());

auto.DisplayCurrentFuelRange();

auto.GetDistance(630, 25);


Console.WriteLine("-----------");

CargoCar cargo = new CargoCar(1000, 1000, 25.0, 630.0, 25.0, 200.0);

Console.WriteLine(cargo.NameOfType);

Console.WriteLine(cargo.GetFullKilometers());

cargo.DisplayCurrentFuelRange();

cargo.GetDistance(630, 25);

Console.WriteLine("-----------");


SportCar sport = new SportCar(25.0, 650.0, 25.0, 200.0);

Console.WriteLine(sport.NameOfType);

Console.WriteLine(sport.GetFullKilometers());

sport.DisplayCurrentFuelRange();

sport.GetDistance(650, 25);

