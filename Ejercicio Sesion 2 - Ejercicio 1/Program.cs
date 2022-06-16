

Console.WriteLine("Ingresa tu Nombre");
string? name = Console.ReadLine();
Console.WriteLine("Ingresa tu Apellido");
string? surname = Console.ReadLine(); 
Console.WriteLine("Ingresa tu Edad");
int? age = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Ingresa tu Ciudad");
string? city = Console.ReadLine();


string message = $"Hola mi nombre es {name} {surname}, tengo {age} y vivo en {city}";

Console.WriteLine(message);
