namespace OLX.Common.Entities;

public class Image
{
    public int Id { get; set; } 
    public string ImageUrl { get; set; }
    
    public int AdvertisementId { get; set; }
    public Advertisement Advertisement { get; set; }
}