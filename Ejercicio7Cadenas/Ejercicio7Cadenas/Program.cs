using static System.Console;

string? enunciado = null;
string[] palabrasSueltas = { "" };
    
PedirFrase();
MostrarPalabras(palabrasSueltas);

return;

void PedirFrase()
{
    

    do
    {
        Write("Escribe un enunciado: ");
        enunciado = ReadLine() ?? string.Empty;
        palabrasSueltas = enunciado.Split(" "); //Dividimos en palabras cuando haya un espacio
        if (palabrasSueltas.Length <= 1)
            WriteLine("Escribe un enunciado con al menos 2 palabras");
        
    }while(palabrasSueltas.Length <= 1);
}

void MostrarPalabras(string[] palabras)
{
    WriteLine($"Primera palabra: {palabras[0]}");
    WriteLine($"Última palabra: {palabras[palabras.Length - 1]}");
}