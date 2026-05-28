using System.Collections;

namespace Unidad4PozzerOteroNaranjoSosaTis;


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
















