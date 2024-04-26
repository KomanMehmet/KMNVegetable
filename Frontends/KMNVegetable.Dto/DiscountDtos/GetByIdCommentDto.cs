namespace KMNVegetable.Dto.DiscountDtos
{
    public class GetByIdCommentDto
    {
        public int DiscountID { get; set; }

        public string DiscoundProductName { get; set; }

        public string DiscoundProductAmount { get; set; }

        public int ProductID { get; set; }
    }
}
