using System.Text.RegularExpressions;
using static System.Console;

//Valores globales (para usarlos luego)
string nombre = null;
string biografía = null;
string correo = null;

PedirNombre();
PedirBiografía();
PedirCorreo();

//MOSTRAR RESULTADOS
WriteLine($"Nombre: {nombre} - Longitud: {nombre.Length}");
WriteLine($"Biografía: {biografía} - Contiene @: {(biografía.Contains("@") ? "SI" : "NO")}");
WriteLine($"Correo: {correo.ToLower()}");

return;

void PedirNombre()
{
    string patronNombre = @"^[A-Za-z]+$";
    bool nombreValido = false;
    do
    {
        Write("Nombre: ");
        nombre = ReadLine()?.Trim().ToUpper() ?? "Desconocido";
        nombreValido = Regex.IsMatch(nombre, patronNombre);
        if (!nombreValido)
            WriteLine("Introduce un nombre válido, sin números");
    } while (!nombreValido);
}

void PedirBiografía()
{
    WriteLine("Cuéntame algo sobre tí: ");
    biografía = ReadLine()?.Trim().ToUpper() ?? string.Empty;
}

void PedirCorreo()
{
    string patronCorreo = @"^[a-zA-Z0-9%_]+@[a-zA-Z0-9%_]+.[a-z]{2,}$";
    bool correoValido = false;
    do
    {
        Write("Correo electrónico: ");
        correo = ReadLine()?.Trim() ?? "Desconocido";
        correoValido = Regex.IsMatch(correo, patronCorreo);
        if (!correoValido)
            WriteLine("Introduce un correo válido: ejemplo@ejemplo.com");
    } while (!correoValido);
}
