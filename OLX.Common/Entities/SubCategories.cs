namespace OLX.Common.Entities;

public class SubCategories
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}