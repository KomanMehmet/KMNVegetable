﻿namespace KMNVegetable.Application.Features.Mediator.Results.BillingResults
{
    public class GetBillingByIdQueryResult
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