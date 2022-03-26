/*
6) Escriba una consulta que sustituya la cadena 'ia' por el asterisco (*) en una lista de palabras dada.
Ejemplo: "estudiar", "caminar", "dia" →  "estud*r", "caminar", "d*"
*/

namespace PracticaLinq
{
    public class Ej6
    {
        public Ej6()
        {

        }
        public static IList<string> ReemplazarIa(List<string> palabras)
        {
            return palabras.Select(x => x.Replace("ia", "*")).ToList(); 
        }
    }
}
