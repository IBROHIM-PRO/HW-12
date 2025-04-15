namespace Domain;

public class Student
{
    [Key]
    public int Id { get; set; }
    
    public string? Name { get; set; } = null;
    
    public int GroupId { get; set; }
    
}
