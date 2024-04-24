namespace KMNVegetable.Domain.Entities
{
    public class Comment
    {
        public int CommentID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Review { get; set; }

        public int Rating { get; set; }

        public Product Product { get; set; }

        public int ProductID { get; set; }
    }
}
