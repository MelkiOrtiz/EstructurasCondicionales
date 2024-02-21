// Ahora Utilizando Switch
Console.WriteLine("*Convertir un numero de letra a numero*");
Console.WriteLine("Ingrese un número del 1 al 5 en letras:");
string numeroEnLetra = Console.ReadLine().ToLower();
int numeroEnNumero = 0;
switch (numeroEnLetra)
{
    case "uno":
        numeroEnNumero = 1;
        break;
    case "dos":
        numeroEnNumero = 2;
        break;
    case "tres":
        numeroEnNumero = 3;
        break;
    case "cuatro":
        numeroEnNumero = 4;
        break;
    case "cinco":
        numeroEnNumero = 5;
        break;
    default:
        Console.WriteLine("Número no válido.");
        return;
}
Console.WriteLine($"El número en dígito es: {numeroEnNumero}");
    