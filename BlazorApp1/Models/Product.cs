namespace BlazorApp1.Models
{
    public class Product
    {
    public int Id { get; set; }
        public string Title { get; set; }
        public string? Price { get; set; }
        public string description { get; set; }
    
    //foraneas
    public int CategoryId { get; set; }
    
    public string[] images { get; set; }

    public string? Image { get; set; }
    }
}
