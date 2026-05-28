namespace Unidad4PozzerOteroNaranjoSosaTis;

/*
    Integrantes del Grupo "Byte Builders":
    -   Jose Nicolas Pozzer -   DNI: 42579253
    -   Ignacio Otero       -   DNI: 47029270
    -   Noheli Naranjo Vega -   DNI: 39894892
    -   Ignacio Sosa        -   DNI: 28079719
    -   Maximiliano Tis     -   DNI: 33686725
*/
class Program
{
    static void Main(string[] args)
    {
        /*
         *  2- Crear una función que muestre un mensaje pasado como parámetro y utilizarla en todos los puntos del ejercicio.
         *  3- Crear una función que pida la altura en centímetros de 5 personas guardando en un arreglo los valores,
         *      luego recorrer el arreglo y mostrar el mas alto y el mas bajo.
         *  4- Hacer una función que ingresen las notas de los alumnos y los guarde en un ArrayList. Luego calcular y
         *      mostrar el promedio, nota máxima y mínima.
         *  5- Hacer una función que actúe como un diccionario en donde el usuario ingresa una palabra y nos devuelve
         *      la definición usando la colección Hashtable (inicializar con al menos 5 palabras).
         *  6- Hacer un función que le solicite al usuario 4 números y luego los muestre en orden descendente.
         */
        
        Mensaje("--- Inicio del Programa ---");
        SolicitarAlturas_.SolicitarAlturas();                    // PUNTO 3
        SolicitarYCalcularNotas_.SolicitarYCalcularNotas();      // PUNTO 4
        DiccionarioPalabras_.DiccionarioPalabras();              // PUNTO 5
        OrdenarNumerosDescendente_.OrdenarNumerosDescendente();  // PUNTO 6
    }

    // Funcion de Mensaje para reutilizar en cada Ejecicio
    public static void Mensaje(string mensaje)
    {
        Console.WriteLine(mensaje);
    }
}
















