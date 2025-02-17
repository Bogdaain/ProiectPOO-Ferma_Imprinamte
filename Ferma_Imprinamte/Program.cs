﻿using Ferma_Imprinamte.Classes;
namespace Ferma_Imprinamte;

class Program
{
    private static Ferma fermaImprimante = new Ferma();

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Meniu Principal:");
            Console.WriteLine("1. Utilizator");
            Console.WriteLine("2. Administrator");
            Console.WriteLine("3. Iesire");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    MeniuUtilizator();
                    break;
                case "2":
                    MeniuAdministrator();
                    break;
                case "3":
                    Console.WriteLine("La revedere!");
                    return;
                default:
                    Console.WriteLine("Optiune invalida. Incearca din nou.");
                    break;
            }
        }
    }

    private static void MeniuUtilizator()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Meniu Utilizator:");
            Console.WriteLine("1. Vizualizare costuri");
            Console.WriteLine("2. Calculeaza cost obiect");
            Console.WriteLine("3. Plaseaza o comanda");
            Console.WriteLine("4. Inapoi la meniul principal");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine(fermaImprimante.VizualizareCosturi());
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine(fermaImprimante.VizualizareImprimante());
                    Console.Write("Introdu CNP-ul imprimantei pentru calculul costului: ");
                    if (int.TryParse(Console.ReadLine(), out int cnpImprimanta))
                    {
                        Console.Write("Introdu greutatea obiectului: ");
                        if (double.TryParse(Console.ReadLine(), out double greutate))
                        {
                            Console.WriteLine(fermaImprimante.CalculeazaCostObiect(greutate, cnpImprimanta));
                        }
                        else
                        {
                            Console.WriteLine("Greutate invalida.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("CNP invalid.");
                    }

                    Console.ReadKey();
                    break;
                case "3":
                    Console.Write("Introdu numele obiectului: ");
                    string numeObiect = Console.ReadLine();
                    Console.Write("Introdu greutatea obiectului: ");
                    if (double.TryParse(Console.ReadLine(), out double greutateComanda))
                    {
                        Console.Write("Introdu culoarea obiectului: ");
                        string culoareObiect = Console.ReadLine();
                        Console.Write("Introdu adresa de livrare: ");
                        string adresaComanda = Console.ReadLine();

                        Console.WriteLine(fermaImprimante.PlaseazaComanda(numeObiect, greutateComanda,
                            culoareObiect, adresaComanda));
                    }
                    else
                    {
                        Console.WriteLine("Greutate invalida.");
                    }

                    Console.ReadKey();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Optiune invalida. Incearca din nou.");
                    break;
            }
        }
    }

    private static void MeniuAdministrator()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Meniu Administrator:");
            Console.WriteLine("1. Vizualizare status imprimante");
            Console.WriteLine("2. Vizualizare detalii imprimanta");
            Console.WriteLine("3. Adaugare rasina");
            Console.WriteLine("4. Vizualizare stoc filament");
            Console.WriteLine("5. Adauga filament in stoc");
            Console.WriteLine("6. Inapoi la meniul principal");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine(fermaImprimante.VizualizareImprimante());
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Write("Introdu CNP-ul imprimantei: ");
                    if (int.TryParse(Console.ReadLine(), out int cnp))
                    {
                        var imprimanta = fermaImprimante.printere.Find(i => i.CNP == cnp);
                        if (imprimanta != null)
                        {
                            Console.WriteLine(fermaImprimante.DetaliiImprimanta(cnp));
                        }
                        else
                        {
                            Console.WriteLine("Imprimanta nu a fost gasita.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("CNP invalid.");
                    }

                    Console.ReadKey();
                    break;
                case "3":
                    Console.Write("Introdu CNP-ul imprimantei pentru adaugare rasina: ");
                    if (int.TryParse(Console.ReadLine(), out int cnpRasina))
                    {
                        Console.Write("Introdu cantitatea de rasina de adaugat: ");
                        if (double.TryParse(Console.ReadLine(), out double cantitateRasina))
                        {
                            Console.WriteLine(fermaImprimante.AdaugareRasina(cnpRasina, cantitateRasina));
                        }
                        else
                        {
                            Console.WriteLine("Cantitate de rasina invalida.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("CNP invalid.");
                    }

                    Console.ReadKey();
                    break;
                case "4":
                    Console.WriteLine(fermaImprimante.VizualizareStocFilament());
                    Console.ReadKey();
                    break;
                case "5":
                    Console.Write("Introdu tipul filamentului: ");
                    string tipFilament = Console.ReadLine();
                    Console.Write("Introdu culoarea filamentului: ");
                    string culoareFilament = Console.ReadLine();
                    Console.Write("Introdu cantitatea filamentului (in grame): ");
                    if (double.TryParse(Console.ReadLine(), out double cantitateFilament))
                    {
                        Console.WriteLine(fermaImprimante.AdaugaFilamentInStoc(tipFilament, culoareFilament,
                            cantitateFilament));
                    }
                    else
                    {
                        Console.WriteLine("Cantitatea introdusa nu este valida.");
                    }

                    Console.ReadKey();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Optiune invalida. Incearca din nou.");
                    break;
            }
        }
    }
}

