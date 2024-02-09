using Data;
public static class DataManager
{
    public static List<Items> items = new()
    {
    new Items("Wood", "Strong, flexible and light material from trees" ),
    new Items("Stone", "It is a rock"),
    new Items("Rope", "Ye" )

    };
    public static List<Enemy> enemies = new()
    {
    new Enemy("Troll", "Fat and ugly" ),
    new Enemy("Slime", "Weird and slimy"),
    new Enemy("Wolf", "Wild and hungry" )
    };
    public static List<Biomes> biomes = new()
    {
    new Biomes("Forest", "Full of trees and wildlife" ),
    new Biomes("Desert", "Dry and empty"),
    new Biomes("Sea", "Full of fish" )
    };

    public static string GetMain()
    {
        return $"Vikipedia\n- items\n- enemies\n- biomes";
    }
    public static string GetContainerMenu(List<DataContainer> container)
    {
        return $"All {container}: 0 - {container.Count - 1}";
    }
    public static IResult GetEnemy(List<DataContainer> container, int id)
    {
        if (id >= container.Count || id < 0)
        {
            return Results.NotFound();
        }

        return Results.Ok(container[id]);
    }

}
public class DataContainer
{

}