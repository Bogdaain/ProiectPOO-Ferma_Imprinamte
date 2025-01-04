using Ferma_Imprinamte.Classes;
namespace Ferma_Imprinamte;
class Program
{
    static List<Printer> printere = new List<Printer>();
    static List<string> comenzi = new List<string>();
    static Dictionary<string, double> stocFilament = new Dictionary<string, double>();
    static double costPerGramRasina = 0.5;
    static double costPerGramPlastic = 0.3;
    static void Main(string[] args)
    {
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Alegeto o optiune: ");
            Console.WriteLine("1. Utilizator\\n2. Administrator\\n3. Iesire");
            string optiune = Console.ReadLine();

            switch (optiune)
            {
                case "1":
                    break;
                    
            }
        }
    }
}