using System.Xml.Schema;

namespace Lab3;

public class Database
{
    public static List<Vehicle> Vehicle { get; set; } = 
    [
        new Bike(engineCapacity:0.6,model:"Yamaha",year:2025),
        new Bike(engineCapacity:0.9,model:"Kawasaki",year:2025),
        new Bike(engineCapacity:2.0,model:"VW",year:2006),
        new Bike(engineCapacity:1.0,model:"Fiat", year:2018),
        new Car(engineCapacity:2.0, model:"Skoda", year:2010),
    ];

 
}