

Coche coche = new Coche();

coche.Puertas = 5;
coche.Ruedas = 4;
coche.Marca = "Fiat";
coche.ITVvigente = true;

Mesa mesa = new Mesa();

mesa.Peso = 110.2;
mesa.Largo = 28.5;
mesa.Material = "Madera";
mesa.Color = "Marron";


public class Coche{

    public Coche(){}

    public int Puertas { get; set; }
    public int Ruedas { get; set; }
    public string? Marca { get; set; }
    public bool ITVvigente { get; set; }
}

public class Mesa
{
    public Mesa() { }

    public double Peso { get; set; }
    public double Largo { get; set; }
    public string? Material { get; set; }
    public string? Color { get; set; }
}
