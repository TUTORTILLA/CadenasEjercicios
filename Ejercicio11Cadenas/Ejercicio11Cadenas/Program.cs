using System.Text.RegularExpressions;
using static System.Console;

string numero;
string númeroConvertido;
PedirNúmeroTeléfono();

númeroConvertido = ConvertirNúmero(numero);
WriteLine($"Texto convertido: {númeroConvertido}");


return;

void PedirNúmeroTeléfono()
{
    string patrónNúmero = @"^\d{9}$";
    bool númeroVálido;
    do
    {
        WriteLine("CONVERTIDOR NÚMERO");
        Write("Introduce tu número de teléfono: ");
        numero = ReadLine()?.Trim() ?? "Desconocido";

        númeroVálido = Regex.IsMatch(numero, patrónNúmero);
        if (!númeroVálido)
            WriteLine("INTRODUCE UN NÚMERO VÁLIDO (9 dígitos)");
    } while (!númeroVálido);
}

string ConvertirNúmero(string valor)
{
    string parte1 = numero.Substring(0, 3);
    string parte2 = numero.Substring(3, 3);
    string parte3 = numero.Substring(6, 3);
    return $"(+34)-{parte1}-{parte2}-{parte3}";
}