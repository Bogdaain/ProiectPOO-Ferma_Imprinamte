namespace Ferma_Imprinamte.Classes;

public abstract class Printer
{
    public int CNP { get; set; }
    public string Status { get; set; }

    protected Printer(int cnp, string status)
    {
        CNP = cnp;
        Status = status;
    }
}