

Figure figure = new Figure();

figure.DrawFigure();

public class Figure{

    public int Ancho { get; set; }
    public int Alto { get; set; }
    public bool IsFilled { get; set; }
    public int FiguresNumberToDraw { get; set; }

    public Figure(){
        
        Ancho = Convert.ToInt32(Console.ReadLine());
        Alto = Convert.ToInt32(Console.ReadLine());
        FiguresNumberToDraw = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese si el cuadrado esta relleno: s / n");
        IsFilled = Console.ReadLine() == "s" ? true : false;
    }

    public void DrawFigure()
    {
        string aux = "";

        for (int x = 0; x < FiguresNumberToDraw; x++)
        {
            if (IsFilled)
            {
                for (int i = 0; i <= Alto - 1; i++)
                {
                    for (int j = 0; j <= Ancho - 1; j++)
                    {
                        aux += "* ";
                    }
                    Console.WriteLine(aux + "\n");
                    aux = "";
                }
            }
            if (!IsFilled)
            {

                for (int i = 0; i <= Alto - 1; i++)
                {
                    if (i == 0)
                    {
                        for (int j = 0; j <= Ancho - 1; j++)
                        {
                            aux += "* ";
                        }
                        Console.WriteLine(aux + "\n");
                        aux = "";
                    }
                    if (i == Alto - 1)
                    {
                        for (int j = 0; j <= Ancho - 1; j++)
                        {
                            aux += "* ";
                        }
                        Console.WriteLine(aux + "\n");
                        aux = "";
                    }
                    if (i > 0 && i != Alto - 1)
                    {
                        for (int j = 0; j <= Ancho; j++)
                        {
                            if (j == 0 || j == Ancho)
                            {
                                aux += "* ";
                            }
                            else
                            {
                                aux += " ";
                            }
                        }
                        Console.WriteLine(aux + "\n");
                        aux = "";
                    }
                }
            }
            Console.WriteLine("\n\n");
        }
        
    }

}
