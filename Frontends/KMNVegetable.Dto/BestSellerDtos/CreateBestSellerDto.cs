﻿namespace KMNVegetable.Dto.BestSellerDtos
{
    public class CreateBestSellerDto
    {
        public string BestSellerProductName { get; set; }

        public string Rating { get; set; }

        public decimal Price { get; set; }

        public int ProductID { get; set; }
    }
}
