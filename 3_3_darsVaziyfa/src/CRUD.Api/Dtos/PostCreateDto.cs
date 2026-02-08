namespace CRUD.Api.Dtos
{
    public class PostCreateDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid UserId { get; internal set; }
    }
}
