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
        comenzi.Add(comandaNoua);
        return "Comanda a fost efectuata";
    }

    public string PreluareComenzi()
    {
        if (comenzi.Count == 0)
        {
            return "Nu sunt comenzi disponibile";
        }

        string rezultat = "Comenzile sunt urmatoarele: ";
        foreach (var comanda in comenzi)
        {
            rezultat += comanda.ToString() + " ";
        }
        return rezultat;
    }

    //public string ProcesareaComenzilor(Ferma ferma)
    //{
        
   // }
}