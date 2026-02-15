namespace CRM.Api.Dtos;

public class UserCreateDto
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Company { get; set; }
    public DateTime CreatedAt { get; set; }
}
