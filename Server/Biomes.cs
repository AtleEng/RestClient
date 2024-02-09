namespace Data;

public class Biomes : DataContainer
{
    public string Name { get; set; }
    public string describtion { get; set; }

    public Biomes(string name, string describtion)
    {
        this.Name = name;
        this.describtion = describtion;
    }
}