using DefaultNamespace;

namespace Ferma_Imprinamte.Classes;

public class Ferma
{
    private List<Printer> printere;

    public Ferma()
    {
        printere = new List<Printer>();
    }

    public string InventarImprimante()
    {
        if(printere.Count == 0)
            return "Nu exista imprimante disponibile";
        string inventar = "Imprimante:\n";
        foreach (var printer in printere)
        {
            inventar += $"ID: {printer.CNP}, Status: {printer.Status}\n";
        }
        return inventar;
    }

    public string DetaliiImprimata(int cnp)
    {
        Printer printer = null;
        foreach (var p in printere)
        {
            if (p.CNP == cnp)
            {
                printer = p;
                break;
            }
        }
        if (printer == null)
        {
            return "Nu sa gasit imprimanta.";
        }
        else
        {
            return printer.ToString();    
        }
    }
    public string AdaugareRasina(int cnp)
    {
        RasinaPrinter rasinaPrinter = null;
        foreach (var p in printere)
        {
            if (p.CNP == cnp && p is RasinaPrinter)
            {
                rasinaPrinter = (RasinaPrinter)p; // aruncca exceptia daca p nu e de tipul ResinaPrinter
                break;
            }
        }
        if (rasinaPrinter == null)
            return "Imprimanta nu a fost gasita";
        rasinaPrinter.AdaugareRasina();
        return "Rasina adaugata cu succes";
    }
    
}