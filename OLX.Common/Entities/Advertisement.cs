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
    
    public int UserId { get; set; }
    public User User { get; set; }
    
    public int SubRegionId { get; set; }
    public SubRegion SubRegion { get; set; }
    
    public int SubCategoryId { get; set; }
    public SubCategories SubCategories { get; set; }
}