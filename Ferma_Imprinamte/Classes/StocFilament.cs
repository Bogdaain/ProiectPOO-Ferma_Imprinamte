namespace DefaultNamespace;

public class StocFilament
{
    public double CostPerGramRasina { get; private set; } = 0.5;
    public double CostPerGramPlastic { get; private set; } = 0.3;
    private Dictionary<string, double> stoc;
    public StocFilament()
    {
        stoc = new Dictionary<string, double>();
    }

    public void AdaugaFilament(string tip, string color, double cantitate)
    {
        string key = $"{tip}-{color}";
        if (stoc.ContainsKey(key))
        {
            stoc[key] += cantitate;
        }
        else
        {
            stoc[key] = cantitate;
        }
    }

    public string DetaliiStoc()
    {
        if (stoc.Count == 0)
            return "Nu există niciun filament în stoc.";

        List<string> rezultat = new List<string> { "Stoc de filament: " };
        foreach (var item in stoc)
        {
            rezultat.Add($"{item.Key}: {item.Value} gr");
        }

        return string.Join("\n", rezultat);
    }

    public void StergereStoc()
    {
        var obiectSters = new List<string>();
        foreach (var item in stoc)
        {
            if (item.Value < 10)
            {
                obiectSters.Add(item.Key);
            }
        }

        foreach (var key in obiectSters)
        {
            stoc.Remove(key);
        }
    }
}