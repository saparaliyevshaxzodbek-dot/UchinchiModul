namespace CRM.Api.Models;

public class User
{
    public Guid UserId { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Company { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid Id { get; internal set; }
}