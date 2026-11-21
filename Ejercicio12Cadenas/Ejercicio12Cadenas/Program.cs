using static System.Console;

string cadena;
string parteBusqueda;
PedirCadena();
BuscarTexto(cadena);
cadena = Reemplazar(cadena, parteBusqueda);
WriteLine($"Texto actualizado: \n{cadena}");
return;

void PedirCadena()
{ 
    Write("Escribe un enunciado: ");
    cadena = ReadLine()?.ToLower() ?? "Desconocido";
}

void BuscarTexto(string texto)
{
    bool parteVálida = false;
    do
    {
        Write("¿Qué parte quieres reemplazar? : ");
        parteBusqueda = ReadLine()?.Trim().ToLower() ?? "Desconocido";
        if (cadena.Contains(parteBusqueda))
        {
            parteVálida = true;
        }
        else
        {
            WriteLine($"No se ha encontrado la parte: {parteBusqueda} en el texto: {cadena}");
        }
    }while(!parteVálida);
}

string Reemplazar(string enunciado, string parte)
{
    string texto;
    
    Write("Escribe el nuevo texto: ");
    texto = ReadLine()?.ToLower();

    return enunciado.Replace(parte, texto);
}