using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using Lab3;
bool run=true;
do
{
    Console.WriteLine("CAR SHOP");
    Console.WriteLine("[1] Show All, [2]Search by year, [3]Search by model,[4]Search by engine capacity, [5]Add car, [0]Exit");
    var input = Console.ReadKey().KeyChar;
    Console .WriteLine();
    switch (input)
    {
        case '1':
            DisplayVehiclesModel();
            break;
        case'2':
            SearchByYear();
            break;
        case '3' :
            SearchByModel();
            break;
        case'4':
            SearchByEngineCapacity();
            break;
        case'5':
            AddNewVehicle(); 
            break;
        case'0':
            run = false;
            break;
        default:
            Console.WriteLine("Invalid menu option");
            break;
    }
    

} while (run);
Console.WriteLine();
Console.WriteLine("Goodbye...");

void DisplayVehiclesModel()
{
    Console.WriteLine("Our Vehicles:");
    foreach (var vehicle in Database.Vehicle)
    {
        Console.WriteLine(vehicle.Model);
    }
}

void SearchByYear()
{
    Console.WriteLine("Enter year:");
    var success=Int32.TryParse(Console.ReadLine(),out int year);
    if (!success)
    {
        Console.WriteLine("Invalid year");
        SearchByYear();
        return;
    }

    var vehicles = Database.Vehicle.Where(veh => veh.Year == year);
    if (!vehicles.Any())
    {
        Console.WriteLine("No vehicles found");
    }
    else
    {
        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle.Model);
        }
    }
    
}
void SearchByModel()
{
    Console.WriteLine("Enter model:");
    string? searchModel = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(searchModel))
    {
        Console.WriteLine("Invalid model");
        return;
    }

    var vehicles = Database.Vehicle.Where(veh => veh.Model.Equals(searchModel));
    if (!vehicles.Any())
    {
        Console.WriteLine("No vehicles found");
    }
    else
    {
        Console.WriteLine($"Found vehicles for model'{searchModel}': ");
        foreach (var vehicle in vehicles)
        {
            string type;
            if (vehicle is Car)
            {
                type = "Car";
            }
            else if(vehicle is Bike)
            {
                type = "Bike";
            }
            else
            {
                type = "Unknown Type";
            }
            Console.WriteLine($"Model:{vehicle.Model}, Type:{type}, Year:{vehicle.Year}, Engine:{vehicle.EngineCapacity}");
        }
    }
    
}

void SearchByEngineCapacity()
{
    Console.WriteLine("Enter engine capacity:");
    var success = double.TryParse(Console.ReadLine(), out double capacity);
    if (!success || capacity <= 0)
    {
        Console.WriteLine("Invalid engine capacity value.");
        return;
    }

    var vehicles = Database.Vehicle.Where(veh => veh.EngineCapacity == capacity);
    if (!vehicles.Any())
    {
        Console.WriteLine("No vehicles found with this engine capacity");
    }
    else
    {
        Console.WriteLine($"Found vehicles with {capacity}capacty:");
        foreach (var vehicle in vehicles)
        {
            string type;
            if (vehicle is Car)
            {
                type = "Car";
            }
            else if (vehicle is Bike)
            {
                type = "Bike";
            }
            else
            {
                type = "Unknown Type";
            }

            Console.WriteLine($"Type:{type}, Model:{vehicle.Model}, Year:{vehicle.Year}");

        }
    }
}

void AddNewVehicle()
    {
        Console.WriteLine("B for bike, C for Car");
        var input = Console.ReadKey().KeyChar;

        if (input.ToString().ToLower() is not ("b" or "c"))
        {
            Console.WriteLine("Invalid vehicle type");
            return;
        }

        Console.WriteLine();
        Console.WriteLine("Enter Engine Capacity:");
        var success = double.TryParse(Console.ReadLine(), out double engineCapacity);
        if (!success)
        {
            Console.WriteLine("Invalid engine capacity");
            return;
        }

        Console.WriteLine("Enter Model:");
        string? model = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(model))
        {
            Console.WriteLine("Invalid model");
            return;
        }

        Console.WriteLine("Enter Year:");
        success = Int32.TryParse(Console.ReadLine(), out int year);
        if (!success)
        {
            Console.WriteLine("Invalid year");
            return;
        }

        Vehicle v;
        if (input == 'C')
        {
            v = new Car(engineCapacity, model, year);
        }
        else
        {
            v = new Bike(engineCapacity, model, year);
        }

        Database.Vehicle.Add(v);
    }



 

