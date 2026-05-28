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
class SolicitarYCalcularNotas_
{
    // PUNTO 4
    public static void SolicitarYCalcularNotas()
    {
        Program.Mensaje("\n- Punto 4 | Solicitar y Calcular Notas\n");
        
        ArrayList notas = new ArrayList();
        float nota_maxima = 0;
        float nota_minima = 100;
        float acum_notas = 0;
        float promedio = 0;

        bool terminar = false;
        // pedir medidas
        while (!terminar)
        {
            Program.Mensaje("Ingrese la Nota del Alumno: ");
            string input = Console.ReadLine();
            float numero = float.Parse(input);
            
            notas.Add(numero);
            
            // pregunta para terminar bucle de ingreso notas
            Program.Mensaje("Desea ingresar otra nota? s = Si, n = No");
            string pregunta = Console.ReadLine();
            if (pregunta == "n" || pregunta == "N" || pregunta == "no" || pregunta == "No")
            {
                terminar = true;
            }
        }
        
        // calcular y recorrer medidas
        foreach (float item in notas)
        {
            // acumulamos notas, que luego nos servira para calcular promedio
            acum_notas = acum_notas + item;
            if (item > nota_maxima)
            {
                nota_maxima = item;
            }
            if (item < nota_minima)
            {
                nota_minima = item;
            }
        }
        
        // calculamos el promedio
        promedio = acum_notas / notas.Count;
        
        Program.Mensaje("La Nota Maxima Registrada es: " + nota_maxima);
        Program.Mensaje("La Nota Minima Registrada es: " + nota_minima);
        Program.Mensaje("El promedio obtenido de las " + notas.Count + " Notas es: " + promedio.ToString("0.00"));
    }
}
















