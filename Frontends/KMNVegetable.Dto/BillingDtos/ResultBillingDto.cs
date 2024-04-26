namespace KMNVegetable.Dto.BillingDtos
{
    public class ResultBillingDto
    {
        public int BillingID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string Postcode { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string? Annotation { get; set; }
    }
}
