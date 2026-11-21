using System.Text;
using static System.Console;

//Random 
Random rnd = new Random();

//Palabras globales
string palabraElegida; //la palabra elegida
string palabraInput; //la palabra que dirá el jugador

//Array de palabras posibles
string[] palabrasWordle =
{
    "CASA", "PISO", "HOLA", "RATA", "MONO", "AZUL", "ROJO", "AGUA", "TREN", "MANO", "LAGO", "GATO", "ALTO",  "BAJO", "FRIO", "AMAR", "CAER", "NUBE", "FLOR", "DATO", "LUNA"
};

//Contadores
int contadorIntentos = 0;

WriteLine("=== ENCUENTRA LA PALABRA ===");
WriteLine("(* correcta | + mal ubicada | - no está)");
WriteLine();
ElegirPalabra(palabrasWordle);
WriteLine();
WriteLine("  [ * ] [ * ] [ * ] [ * ]");
EscribirPalabra();

return;

void ElegirPalabra(string[] palabras)
{
    int índice = rnd.Next(palabras.Length);
    palabraElegida = palabras[índice]; //Ya tenemos una palabra con la que jugaremos
}

void EscribirPalabra()
{
    bool palabraAcertada = false;
    while (contadorIntentos <= 5 && !palabraAcertada)
    {
        contadorIntentos++;
        do
        {
            Write($"\nIntento {contadorIntentos}/6 - Escribe una palabra: ");
            palabraInput = ReadLine()?.Trim().ToUpper() ?? "Desconocido";

        } while (palabraInput.Length != 4); //lo suyo sería poner el diccionario español para verificar las palabras que se escriban

        palabraAcertada = Comprobante(palabraInput, palabraElegida);
        Validador(palabraInput, palabraElegida);
    }

    WriteLine("\n------------------------------------------------");
    string msj = palabraAcertada ? $"¡HAS ACERTADO LA PALABRA!: {palabraElegida}" : $"SE TE HAN ACABADO LOS INTENTOS. LA PALABRA ERA: {palabraElegida}";
    WriteLine(msj);
    WriteLine("------------------------------------------------");
}

void Validador(string palabraPlayer, string palabraOriginal)
{
    WriteLine();
    Write("  ");
    for (int i = 0; i < palabraPlayer.Length; i++)
    {
        if (palabraPlayer[i] == palabraOriginal[i]) //Acertadisima
        {
            Write($"[ {palabraPlayer[i]}* ] ");
        }
        else
        {
            bool letraExiste = false;
            for (int j = 0; j < palabraOriginal.Length; j++)
            {
                if (palabraPlayer[i] == palabraOriginal[j])
                {
                    letraExiste = true; 
                }
                else if (palabraPlayer[i] != palabraOriginal[j] && !letraExiste)
                {
                    letraExiste = false;
                }
            }

            string msj = letraExiste ? $"[ {palabraPlayer[i]}+ ] " : $"[ {palabraPlayer[i]}- ] ";
            Write(msj);
        }
    }
    WriteLine();
}

bool Comprobante(string palabraPlayer, string palabraOriginal)
{
    for (int i = 0; i < palabraPlayer.Length; i++)
    {
        if (palabraPlayer[i] != palabraOriginal[i]) return false;
    } 
    return true;
}