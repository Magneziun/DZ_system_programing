namespace Core.Model;

public class Product
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public int Pages { get; set; }           
    public decimal Price { get; set; }
    public DateTime PublishDate { get; set; }     
    public int AuthorId { get; set; }         
    public int ThemeId { get; set; }               

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Pages: {Pages}, Price: {Price}, PublishDate: {PublishDate.ToShortDateString()}, AuthorId: {AuthorId}, ThemeId: {ThemeId}";
    }
}