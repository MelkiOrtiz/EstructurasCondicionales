// 1: Calcular el Mayor de Tres Números
try
{
    Console.WriteLine("Ingrese tres números:");
    double num1 = LeerNumero();
    double num2 = LeerNumero();
    double num3 = LeerNumero();
    double mayor = Math.Max(num1, Math.Max(num2, num3));
    Console.WriteLine("El mayor número es: " + mayor);
}
catch (Exception ex)
{
    Console.WriteLine("Ups ocurrio un error: " + ex.Message);
}
static double LeerNumero()
{
    return double.Parse(Console.ReadLine());
}



// 2: Validar Edad para Ingresar a un Club
try
{
    Console.WriteLine("Ingrese su edad:");
    int edad = LeerEntero();
    if (edad >= 18)
    {
        Console.WriteLine("Bienvenido al club insano.");
    }
    else
    {
        Console.WriteLine("Lo siento, no eres muy insano para ingresar al club.");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Edad no valida: " + ex.Message);
}
    

    static int LeerEntero()
{
    return int.Parse(Console.ReadLine());
}


// 3: Calcular el Precio Final de un Producto
try
{
    Console.WriteLine("Ingrese el precio original del producto:");
    double precioOriginal = LeerProducto();
    double precioFinal = precioOriginal;
    if (precioOriginal > 100)
    {
        precioFinal *= 0.9; // Aplicar descuento del 10%
    }
    Console.WriteLine("El precio final es: " + precioFinal);
}
catch (FormatException)
{
    Console.WriteLine("Error: Entrada inválida. Por favor, ingrese un número válido.");
}
catch (Exception ex)
{
    Console.WriteLine("Error inesperado: " + ex.Message);
}
    static double LeerProducto()
{
    return double.Parse(Console.ReadLine());
}

// 4.Validar Usuario Y Contraseña 

Console.WriteLine("*4 Validar usuario y contraseña\n");
string usuarioValido = "Melki"; 
string contrasenaValida = "TilinInsano";
Console.WriteLine("Ingrese su nombre de usuario: \n");
string usuarioIngresado = Console.ReadLine(); 
Console.WriteLine("Ingrese su contraseña: \n");
string contrasenaIngresada = Console.ReadLine();
if (usuarioIngresado == usuarioValido && contrasenaIngresada == contrasenaValida)
{
    Console.WriteLine("¡Acceso concedido! Bienvenido.\n");
}
else
{
    Console.WriteLine("Usuario o contraseña incorrectos.\n");
}
