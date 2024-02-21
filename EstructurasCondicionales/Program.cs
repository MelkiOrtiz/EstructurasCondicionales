// 1: Calcular el Mayor de Tres Números
Console.WriteLine("*1 Calcular el mayor de tre numeros*\n");

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
Console.WriteLine("*2 Validar Edad*\n");

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
Console.WriteLine("*3 Calcular el precio final de un producto*\n");

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

Console.WriteLine("*4 Validar usuario y contraseña*\n");
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

// 5.Determinar si un numero es par o impar
Console.WriteLine("*5 Determinar si el numero es par o impar*\n");

try
{
    Console.WriteLine("Ingrese un número:");
    int numero = LeerEnteroo();
    if (numero % 2 == 0)
    {
        Console.WriteLine("El número es par.");
    }
    else
    {
        Console.WriteLine("El número es impar.");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Ups a ocurruido un error: " + ex.Message);
}
    static int LeerEnteroo()
{
    return int.Parse(Console.ReadLine());
}

// 6. Mostrar un Mensaje de Aprobación o Rechazo de Préstamo:
Console.WriteLine("*6 Aprovacion o rechazo de prestamo*\n");
try
{
    Console.WriteLine("Ingrese el monto del préstamo:");
    double montoPrestamo = LeerNumero();
    Console.WriteLine("Ingrese su edad:");
    int edad = LeerEnterooo();
    if (montoPrestamo < 5000 || edad > 60)
    {
        Console.WriteLine("Préstamo aprobado.");
    }
    else
    {
        Console.WriteLine("Préstamo rechazado.");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Error inesperado: " + ex.Message);
}
    static double LeerNumerooo()
{
    return double.Parse(Console.ReadLine());
}
static int LeerEnterooo()
{
    return int.Parse(Console.ReadLine());
}

// 7.Calcular el Área de una Figura Geométrica:
Console.WriteLine("*7 Calcular area de figura geometrica*\n");
try
{
    Console.WriteLine("Ingrese el tipo de figura geométrica (triangulo, cuadrado o círculo):");
    string tipoFigura = Console.ReadLine().ToLower();
    double area = 0;

    if (tipoFigura == "triangulo")
    {
        Console.WriteLine("Ingrese la base del triángulo:");
        double baseTriangulo = LeerNumero();
        Console.WriteLine("Ingrese la altura del triángulo:");
        double alturaTriangulo = LeerNumero();
        area = 0.5 * baseTriangulo * alturaTriangulo;
    }
    else if (tipoFigura == "cuadrado")
    {
        Console.WriteLine("Ingrese el lado del cuadrado:");
        double ladoCuadrado = LeerNumero();
        area = ladoCuadrado * ladoCuadrado;
    }
    else if (tipoFigura == "circulo")
    {
        Console.WriteLine("Ingrese el radio del círculo:");
        double radioCirculo = LeerNumero();
        area = Math.PI * Math.Pow(radioCirculo, 2);
    }
    else
    {
        Console.WriteLine("Figura geométrica no reconocida.");
    }

    Console.WriteLine("El área de la figura es: " + area);
}
catch (Exception ex)
{
    Console.WriteLine("Error inesperado: " + ex.Message);
}  
    static double LeerNumer()
{
    return double.Parse(Console.ReadLine());
}
   
