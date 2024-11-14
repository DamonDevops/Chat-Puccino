using ChatPuccino.Enums;

namespace ChatPuccino.Models;

public class Consumable
{
    public int Id { get; set; }
    public ProductType Type { get; set; }
    public string Image { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public List<string> Ingredients { get; set; }
    public double Price { get; set; }
    public bool IsPromoted { get; set; } = false;
    public bool IsStocked { get; set; }
    public DateTimeOffset? AvailableUntil { get; set; }
}
