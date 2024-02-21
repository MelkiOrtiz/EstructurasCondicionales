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

//--------------------------------------------------------------------------------------------------------------------

// 2. Mostrar dia de la semana a partir de numero
Console.WriteLine("*Dia de la semana a partir de un numero*");
Console.WriteLine("Ingrese un número del 1 al 7 para mostrar el día de la semana:");
int numeroDia = int.Parse(Console.ReadLine());

string diaSemana = "";

switch (numeroDia)
{
    case 1:
        diaSemana = "Lunes";
        break;
    case 2:
        diaSemana = "Martes";
        break;
    case 3:
        diaSemana = "Miércoles";
        break;
    case 4:
        diaSemana = "Jueves";
        break;
    case 5:
        diaSemana = "Viernes";
        break;
    case 6:
        diaSemana = "Sábado";
        break;
    case 7:
        diaSemana = "Domingo";
        break;
    default:
        Console.WriteLine("Número de día no válido.");
        return;
}

Console.WriteLine($"El día de la semana es: {diaSemana}");
    
    