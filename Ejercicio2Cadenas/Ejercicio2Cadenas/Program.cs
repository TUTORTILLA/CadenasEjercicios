using static System.Console;

string cadena1 = PedirCadena();
string cadena2 = PedirCadena();

//Aquí va el algoritmo
bool sonIguales = SonIguales();
WriteLine($"{((sonIguales) ? "Las dos cadenas son iguales" : "Las dos cadenas son distintas")}");

CualEsMásLarga(cadena1, cadena2);
CadenaPrimeraAlfabeticamente(cadena1, cadena2);





return;

string PedirCadena()
{
    Write("Escribe: ");
    return ReadLine() ?? "Desconocido";
}

bool SonIguales()
{
    if (cadena1.Length != cadena2.Length) return false; //Early return. Si no miden lo mismo, es imposible que sean iguales
    for (int i = 0; i < cadena1.Length; i++)
    {
        if (cadena1[i] != cadena2[i]) return false; 
    }

    return true;
};

void CualEsMásLarga(string c1, string c2)
{
    if (c1.Length == c2.Length)
        WriteLine("Las dos cadenas son igual de largas");
    else
    {
        if (c1.Length > c2.Length)
            WriteLine("La primera cadena es más larga que la segunda");
        else if (c2.Length > c1.Length)
            WriteLine("La segunda cadena es más larga que la primera");
    }
}

void CadenaPrimeraAlfabeticamente(string c1, string c2)
{
    if(c1[0] > c2[0]) 
        WriteLine("Alfabeticamente, la primera cadena va primero");
    else if(c2[0] > c1[0]) 
        WriteLine("Alfabeticamente, la segunda cadena va primero");
    else
    {
        WriteLine("Las dos cadenas van en la misma posición alfabeticamente");
    }
}