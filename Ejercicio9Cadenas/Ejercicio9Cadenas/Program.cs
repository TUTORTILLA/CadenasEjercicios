using static System.Console;

string? frase = null;
string[] palabrasSeparadas; 

PedirFrase();
ComprobarPalabraMásLarga(palabrasSeparadas);

return;

void PedirFrase()
{
    do
    {
        Write("Escribe una frase con al menos 2 palabras: ");
        frase = ReadLine() ?? "Desconocido";
        palabrasSeparadas = frase.Split(" ");
        if (palabrasSeparadas.Length < 2)
            WriteLine("La frase debe contener al menos dos palabras separadas por un espacio");
    } while (palabrasSeparadas.Length < 2);
}

void ComprobarPalabraMásLarga(string[] palabras)
{
    var palabraMáxima = palabras[0];
    for (int i = 0; i < palabras.Length; i++)
    {
        if (palabras[i].Length > palabraMáxima.Length)
            palabraMáxima =  palabras[i];
    }
    WriteLine($"La palabra más larga del enunciado es: {palabraMáxima}");
}