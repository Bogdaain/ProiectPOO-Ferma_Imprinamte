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
        Printer imprimanta = null;

        foreach (var printer in printere)
        {
            if (printer.CNP == cnp)
            {
                imprimanta = printer;
                break;
            }
        }

        if (imprimanta == null)
        {
            return "Imprimanta nu a fost gasita.";
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
                   $"Tip Material: Rasina\n" +
                   $"Status: {imprimanta.Status}\n";
        }
        else
        {
            return "Imprimanta nu este de tip Plastic sau Rasina.";
        }
    }
    public string AdaugareRasina(int cnp, double cantitateRasina)
    {
        RasinaPrinter imprimanta = null;

        foreach (var printer in printere)
        {
            if (printer.CNP == cnp && printer is RasinaPrinter)
            {
                imprimanta = (RasinaPrinter)printer;
                break;
            }
        }
        if (imprimanta == null)
            return "Imprimanta nu a fost gasita sau nu este de tipul RasinaPrinter.";

        imprimanta.AdaugareRasina(cantitateRasina);
        return "Rasina adaugata cu succes.";
    }
    public string VizualizareImprimante()
    {
        if (printere.Count == 0)
            return "Nu exista imprimante disponibile.";

        List<string> inventar = new List<string> { "Imprimante:" };
        foreach (var printer in printere)
        {
            inventar.Add($"ID: {printer.CNP}, Status: {printer.Status}");
        }

        return string.Join("\n", inventar);
    }
    public string VizualizareStocFilament()
    {
        return stocFilament.DetaliiStoc();
    }

    public string AdaugaFilamentInStoc(string tip, string culoare, double cantitate)
    {
        stocFilament.AdaugaFilament(tip, culoare, cantitate);
        return "Filament adaugat cu succes.";
    }

    public string SchimbareFilamentInStoc(int cnp, StocFilament stoc)
    {
        PlasticPrinter plasticPrinter = null;

        foreach (var p in printere)
        {
            if (p.CNP == cnp && p is PlasticPrinter)
            {
                plasticPrinter = p as PlasticPrinter;
                break;
            }
        }
        if (plasticPrinter == null)
            return "Imprimanta nu a fost gasita sau nu este de tipul PlasticPrinter.";

        return plasticPrinter.SchimbaFilament(stoc);
    }
}