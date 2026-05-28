using System.Collections;

namespace Unidad4PozzerOteroNaranjoSosaTis;


class SolicitarAlturas_
{
    // PUNTO 3
    public static void SolicitarAlturas()
    {
        Program.Mensaje("\n- Punto 3 | Solicitar Altura en cm de 5 Personas\n");
        
        ArrayList alturas = new ArrayList();
        int altura_maxima = 0;
        int altura_minima = 300;

        // pedir medidas
        for (int i = 1; i <= 5; i++)
        {
            Program.Mensaje("Ingrese la altura de la persona Nro. " + i + ": ");
            string input = Console.ReadLine();
            int numero = int.Parse(input);
            
            alturas.Add(numero);
        }
        
        // calcular y recorrer medidas
        foreach (int item in alturas)
        {
            
            if (item > altura_maxima)
            {
                altura_maxima = item;
            }
            if (item < altura_minima)
            {
                altura_minima = item;
            }
        }
        Program.Mensaje("La altura Maxima Registrada es: " + altura_maxima + "cm");
        Program.Mensaje("La altura Minima Registrada es: " + altura_minima + "cm");
    }
}
















