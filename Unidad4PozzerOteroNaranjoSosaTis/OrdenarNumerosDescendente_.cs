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
class OrdenarNumerosDescendente_
{
    // PUNTO 6
    public static void OrdenarNumerosDescendente()
    {
        Program.Mensaje("\n- Punto 6 | Ordenar Numeros de Manera Descendente\n");
        
        ArrayList numeros = new ArrayList();

        for (int i = 1; i <= 4; i++)
        {
            Program.Mensaje("Ingrese el numero Nro. " + i + ": ");
            string input = Console.ReadLine();

            int numero = int.Parse(input);

            numeros.Add(numero);
        }

        numeros.Sort();
        numeros.Reverse();

        Program.Mensaje("Numeros ordenados de mayor a menor:");

        foreach (var item in numeros)
        {
            Program.Mensaje(item.ToString());
        }
    }
}
















