namespace Ferma_Imprinamte.Classes;

public class Comanda
{
    public string Nume { get; set; }
    public double Greutate { get; set; }
    public string Culoare { get; set; }
    public string Adresa { get; set; }

    public override string ToString()
    {
        return $"Comanda : {Nume}, cu greutatea : {Greutate}, culoarea:{Culoare},adresa: {Adresa} ";
    }
}