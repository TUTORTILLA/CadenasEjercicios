using static System.Console;

string palabra = null;

PedirCadena();
palabra = InvertirCadena(palabra);
WriteLine(palabra);


return;

void PedirCadena()
{
    Write("Escribe un enunciado o palabra para invertirla: ");
    palabra = ReadLine() ?? "Desconocido";
}

string InvertirCadena(string cadena)
{
    char[] chars = cadena.ToCharArray();
    for (int i = 0; i < chars.Length / 2; i++)
    {
        (chars[i], chars[chars.Length -1 -i]) = (chars[chars.Length -1 -i], chars[i]);
    }

    return new string(chars);
}