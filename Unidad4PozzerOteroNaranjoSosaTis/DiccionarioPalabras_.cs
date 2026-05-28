using System.Collections;

namespace Unidad4PozzerOteroNaranjoSosaTis;

/*
    Integrantes del Grupo "Byte Builders":
    -   Jose Nicolas Pozzer -   DNI: 42579253
    -   Ignacio Otero       -   DNI: 47029270
    -   Noheli Naranjo Vega -   DNI: 39894892
    -   Ignacio Sosa        -   DNI: 28079719
    -   Maximiliano Tis     -   DNI: 33686725
*/
class DiccionarioPalabras_
{
    // PUNTO 5
    public static void DiccionarioPalabras()
    {
        Program.Mensaje("\n- Punto 5 | Diccionario de Palabras\n");
        
        Hashtable diccionario = new Hashtable();
        
        // agregamos los 5 ejemplos
        diccionario.Add("backend", "Parte logica de una aplicacion");
        diccionario.Add("frontend", "Parte visual de una aplicacion");
        diccionario.Add("cpu", "Procesador principal de la computadora");
        diccionario.Add("ram", "Memoria temporal del sistema");
        diccionario.Add("ssd", "Unidad de almacenamiento rapido");

        Program.Mensaje("Ingrese una palabra para buscar su definicion:");
        string palabra = Console.ReadLine().ToLower();

        // condicional para obtener resultado del input
        if (diccionario.ContainsKey(palabra))
        {
            Program.Mensaje("Definicion: " + diccionario[palabra]);
        }
        else
        {
            Program.Mensaje("La palabra no existe en el diccionario");
        }
    }
}
















