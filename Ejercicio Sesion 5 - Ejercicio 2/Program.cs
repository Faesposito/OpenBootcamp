int number = 0;

Console.WriteLine("Elija el Lenguage de Programacion:\n" +
                  "1- C\n" +
                  "2- C++\n" +
                  "3- C#\n" +
                  "4- Javascript\n");
number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1:
        Console.WriteLine("El Lenguaje que usted eligio es C");
        break;
    case 2:
        Console.WriteLine("El Lenguaje que usted eligio es C++");
        break;
    case 3:
        Console.WriteLine("El Lenguaje que usted eligio es C#");
        break;
    case 4:
        Console.WriteLine("El Lenguaje que usted eligio es Javascript");
        break;

    default:
        Console.WriteLine("Usted No eligio ningun Lenguaje");
        break;
}