using DefaultNamespace;

namespace Ferma_Imprinamte.Classes;
public class Ferma
{
    public List<Printer> printere;
    private StocFilament stocFilament;
    private ServiciuComenzi serviciuComenzi;

    public Ferma()
    {
        printere = new List<Printer>
        {
            new PlasticPrinter(1001, "Disponibil", 1000.0),
            new RasinaPrinter(1002, "Disponibil", 500.0),
            new PlasticPrinter(1003, "Disponibil", 800.0),
            new RasinaPrinter(1004, "In reparatie", 0.0), 
            new PlasticPrinter(1005, "Disponibil", 1200.0)
        };
        stocFilament = new StocFilament();
        serviciuComenzi = new ServiciuComenzi();
    }
    public string VizualizareCosturi()
    {
        return $"Cost per gram rășină: {stocFilament.CostPerGramRasina} RON\n" +
               $"Cost per gram plastic: {stocFilament.CostPerGramPlastic} RON";
    }
    public string CalculeazaCostObiect(double greutate, int cnpImprimanta)
    {
        Printer imprimanta = null;

        foreach (var printer in printere)
        {
            if (printer.CNP == cnpImprimanta)
            {
                imprimanta = printer;
                break;
            }
        }
    
        if (imprimanta == null)
        {
            return "Imprimanta nu a fost găsită.";
        }

        double cost = 0;

        if (imprimanta is PlasticPrinter)
        {
            cost = greutate * stocFilament.CostPerGramPlastic;
        }
        else if (imprimanta is RasinaPrinter)
        {
            cost = greutate * stocFilament.CostPerGramRasina;
        }

        return $"Costul obiectului pe imprimanta cu CNP {cnpImprimanta}: {cost} RON";
    }
    public string PlaseazaComanda(string nume, double greutate, string culoare, string adresa)
    {
        return serviciuComenzi.CreareComanda(nume, greutate, culoare, adresa);
    }
    public string DetaliiImprimanta(int cnp)
    {
        var imprimanta = printere.Find(p => p.CNP == cnp);

        if (imprimanta == null)
        {
            return "Imprimanta nu a fost găsită.";
        }

        if (imprimanta is PlasticPrinter plasticPrinter)
        {
            return $"CNP: {imprimanta.CNP}\n" +
                   $"Tip Material: Plastic\n" +
                   $"Status: {imprimanta.Status}\n";
        }
        else if (imprimanta is RasinaPrinter rasinaPrinter)
        {
            return $"CNP: {imprimanta.CNP}\n" +
                   $"Tip Material: Rășină\n" +
                   $"Status: {imprimanta.Status}\n";
        }
        else
        {
            return "Imprimanta nu este de tip Plastic sau Rășină.";
        }
    }
}