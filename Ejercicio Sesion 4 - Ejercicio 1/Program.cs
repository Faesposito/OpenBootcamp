Console.WriteLine("Ingrese un Numero del cual quiera saber sus multiplos:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n");

int indexer = 1;
while (indexer <= 10)
{
    Console.WriteLine(number * indexer);
    indexer++;
}

