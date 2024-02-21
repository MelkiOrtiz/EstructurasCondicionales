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

//-----------------------------------------------------------------------------------------------------------------

//3.Calcular el Importe a Pagar por un Servicio
Console.WriteLine("*Calcular el importe a pagar por un servicio*");
Console.WriteLine("Ingrese el tipo de servicio (lavado de auto, cambio de aceite, revisión mecánica):");
string tipoServicio = Console.ReadLine().ToLower();
double importe = 0;
switch (tipoServicio)
{
    case "lavado de auto":
        importe = 10.00;
        break;
    case "cambio de aceite":
        importe = 20.00;
        break;
    case "revisión mecánica":
        importe = 30.00;
        break;
    default:
        Console.WriteLine("Tipo de servicio no válido.");
        return;
}
Console.WriteLine($"El importe a pagar por el servicio de {tipoServicio} es: ${importe}");

//----------------------------------------------------------------------------------------------------------------

//4. Mostrar un Mensaje de Bienvenida en Diferentes Idiomas
Console.WriteLine("*Bienvenida en Idiomas*");
Console.WriteLine("Ingrese el idioma de su preferencia (español, ingles, frances):");
string idioma = Console.ReadLine().ToLower();
switch (idioma)
{
    case "español":
        Console.WriteLine("¡Bienvenido!");
        break;
    case "ingles":
        Console.WriteLine("Welcome!");
        break;
    case "frances":
        Console.WriteLine("Bienvenue!");
        break;
    default:
        Console.WriteLine("Idioma no válido.");
        break;
}
    


    