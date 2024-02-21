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
