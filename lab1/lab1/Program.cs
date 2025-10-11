/*const int requiredAge = 18;
const int simCardAge = 16;
const string accessDenied = "Musisz mieć 18 lat.";
const string simCard = "Masz powyżej 16 lat, możesz kupić u nas tylko karte SIM";
const string accessAllowed = "Witamy w naszym sklepie";

int age = 19;

do
{
    Console.WriteLine("Podaj swój wiek: ");

    string input = Console.ReadLine();

    bool success = int.TryParse(input, out age);

    if (!success)
    {
        Console.WriteLine("Podaj poprawną wartość!");
    }
    else
    {
        if (age < simCardAge)
        {
            Console.WriteLine(accessDenied);
        }
        else if (age >= simCardAge && age < requiredAge)
        {
            
                Console.WriteLine(simCard);
        }
        else
        {
            Console.WriteLine(accessAllowed);
        }
    }
} while (age < requiredAge);

*/
// Example 2

// var names = new[] { "Artur", "Alicja", "Michał", "Gosia" };
//
// for (int i = 0; i < names.Length; i++)
// {
//     Console.WriteLine(names[i]);
// }
//
// foreach (var name in names)
// {
//     Console.WriteLine(name);
// }
/*
string password;
do
{
    Console.WriteLine("Podaj hasło: ");
    password = Console.ReadLine();
}
while (password !="admin123");
Console.WriteLine("Zalogowano pomyślnie.");

int liczba;
do
{
    Console.WriteLine("Podaj liczbe wieksza od zera: ");
    liczba = int.Parse(2
    Console.ReadLine());
} 
while (liczba <= 0);

string[] miasta = {" Poznan", "Warszawa", "Krakow","Gdansk","Gdynia" };
foreach (string miasto in miasta )
{
    Console.WriteLine($"Miasto :{miasto}");
}
*/