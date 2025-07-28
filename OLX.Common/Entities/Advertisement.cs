namespace OLX.Common.Entities;

public class Advertisement
{
    public int Id { get; set; } 
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime? SellAt { get; set; }
    public string State { get; set; }
}