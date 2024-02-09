namespace Data;

public class Enemy : DataContainer
{
    public string Name { get; set; }
    public string describtion { get; set; }

    public Enemy(string name, string describtion)
    {
        this.Name = name;
        this.describtion = describtion;
    }
}