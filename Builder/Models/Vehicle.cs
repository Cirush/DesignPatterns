namespace Builder.Models;

public class Vehicle : IVehicle
{
    private List<String> _parts = [];

    public void Add(String part)
    {
        if(!String.IsNullOrEmpty(part)){
            _parts.Add(part);
        }
    
    }

    public string ListParts()
    {
        var str = String.Empty;

        for (int i = 0; i < _parts.Count; i++)
        {
            str += _parts[i] + ", ";
        }

        str = str.Remove(str.Length - 2);

        return "Product parts: " + str + "\n";
    }
}
