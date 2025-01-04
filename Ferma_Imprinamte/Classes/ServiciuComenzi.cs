namespace Ferma_Imprinamte.Classes;

public class ServiciuComenzi
{
    private List<Comanda> comenzi;

    public ServiciuComenzi()
    {
        comenzi = new List<Comanda>();
    }

    public string CreareComanda(string nume, double greutate, string culoare, string adresa)
    {
        Comanda comandaNoua = new Comanda
        {
            Nume = nume,
            Greutate = greutate,
            Culoare = culoare,
            Adresa = adresa
        };
    }
}