using Ferma_Imprinamte.Classes;
namespace Ferma_Imprinamte;
class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Meniu Principal:");
            Console.WriteLine("1. Utilizator");
            Console.WriteLine("2. Administrator");
            Console.WriteLine("3. Iesire");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    MeniuUtilizator();
                    break;
                case "2":
                    MeniuAdministrator();
                    break;
                case "3":
                    Console.WriteLine("La revedere!");
                    return;
                default:
                    Console.WriteLine("Optiune invalida. Incearca din nou.");
                    break;
            }
        }
    }
}