namespace Ejercicio2
{
    public class Person
    {
        public string Nombre { get; set; }
        public int Edad { get; private set; }
        public void Saludar()
        {

        }
        public void SetEdad(int age)
        {
            this.Edad = age;
        }
    }
}
