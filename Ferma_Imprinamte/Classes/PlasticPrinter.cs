using Ferma_Imprinamte.Classes;
namespace DefaultNamespace;

public class PlasticPrinter:Printer
{
    public double CantitateFilament { get; set; }
    public string FilamentCurent { get; set; }

    public PlasticPrinter(int cnp, string status, double cantitateFilament)
        : base(cnp, status)
    {
        CantitateFilament = cantitateFilament;
        FilamentCurent = string.Empty;  
    }
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