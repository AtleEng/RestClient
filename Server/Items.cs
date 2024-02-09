namespace Data;

public class Items : DataContainer
{
    public string Name { get; set; }
    public string describtion { get; set; }

    public Items(string name, string describtion)
    {
        this.Name = name;
        this.describtion = describtion;
    }
}