namespace Singleton
{
    class Program
    {
        static void Main(string[] arga)
        {
            Console.WriteLine(ClaseSingleton.Instance.mensaje);
            ClaseSingleton.Instance.mensaje = "Hola clase Singleton";
            Console.WriteLine(ClaseSingleton.Instance.mensaje);
        }
    }
}