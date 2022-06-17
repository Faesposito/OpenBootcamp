
int positives = 0;
int negatives = 0;

int number = 0;

do
{
    number = Convert.ToInt32(Console.ReadLine());

    number = number > 0 ? positives += number : number;
    number = number < 0 ? negatives += number : number;

} while (number != 0);

Console.WriteLine($"Suma Positiva: {positives} \n Suma Negativa: {negatives}");