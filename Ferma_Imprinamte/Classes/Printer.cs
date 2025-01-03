namespace Ferma_Imprinamte.Classes;

public abstract class Printer
{
    public int CNP { get; set; }
    public string Status { get; set; }

    public override string ToString()
    {
        return $"Printer ID: {CNP}, Status: {Status}";
    }
}