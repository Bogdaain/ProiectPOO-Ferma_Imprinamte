using Ferma_Imprinamte.Classes;
namespace DefaultNamespace;

public class PlasticPrinter:Printer
{
    public string FilamentCurent { get; set; }

    public string SchimbaFilament(StocFilament stoc)
    {
        string nevoieFilament = "plastic-negru";
        if (stoc.DetaliiStoc().Contains(nevoieFilament))
        {
            FilamentCurent = nevoieFilament;
            return "Filamentul sa schimbat cu succes.";
        }

        return "Filamentul neesar nu exista.";
    }
}