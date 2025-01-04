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
        foreach (var priner in printere)
        {
            inventar += $"ID:{printer.CNP}, Status:{printer.Status}\n";
        }
        return inventar;
    }
}