using Ferma_Imprinamte.Classes;
namespace DefaultNamespace;

public class RasinaPrinter :Printer
{
    
    public double RasinaDisponibila { get; set; }
    public RasinaPrinter(int cnp ,string status ,double rasinaDisponibila):base(cnp,status)
    {
        RasinaDisponibila = rasinaDisponibila;
    }
    public void AdaugareRasina(double cantitate)
    {
        RasinaDisponibila += cantitate;
    }
}
