
Cliente cliente = new Cliente();

Console.WriteLine(cliente);

public struct Cliente {

    public string? NombreCompleto { get; set; }
    public double? Telefono { get; set; }
    public string? Direccion { get; set; }
    public string? Email { get; set; }
    public bool? esNuevo { get; set; }
    public Cliente() {

        Console.WriteLine("Ingrese su Nombre Completo:");
        NombreCompleto = Console.ReadLine();

        Console.WriteLine("Ingrese su Telefono:");
        Telefono = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese su Direccion:");
        Direccion = Console.ReadLine();

        Console.WriteLine("Ingrese su Email:");
        Email = Console.ReadLine();

        Console.WriteLine("es usted un cliente nuevo? s / n");
        esNuevo = Console.ReadLine() == "s" ? true : false;
    }
    
    public override string ToString() => $"(Nombre Completo: {NombreCompleto} \n Telefono: {Telefono} \n Direccion: {Direccion} \n Email: {Email}\n)";
   
}