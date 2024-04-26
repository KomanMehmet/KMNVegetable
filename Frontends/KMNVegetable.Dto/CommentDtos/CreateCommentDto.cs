
namespace KMNVegetable.Dto.CommentDtos
{
    public class CreateCommentDto
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Review { get; set; }

        public int Rating { get; set; }

        public int ProductID { get; set; }
    }
}
