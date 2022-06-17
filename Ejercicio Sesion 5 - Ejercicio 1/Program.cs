
int price = 100;
Cliente cliente = new Cliente();

if (cliente.HasCupon)
{
    Console.WriteLine($"Gracias a su Cupon el Precio a quedado en: {price - 20}");
}
else
{
    Console.WriteLine($"Gracias a su Cupon el Precio a quedado en: {price}");
}
public struct Cliente
{

    public string? Name { get; set; }
    public string? Email { get; set; }
    public bool HasCupon { get; set; }
    public Cliente()
    {

        Console.WriteLine("Ingrese su Nombre:");
        Name = Console.ReadLine();

        Console.WriteLine("Ingrese su Email:");
        Email = Console.ReadLine();

        Console.WriteLine("Usted Posee un Cupon de Descuento? s / n");
        HasCupon = Console.ReadLine() == "s" ? true : false;
    }

    public override string ToString() => $"(Nombre: {Name} \n Email: {Email}\n)";

}