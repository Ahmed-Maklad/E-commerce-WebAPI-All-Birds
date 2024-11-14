﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBirds.DTOs.OrderDetailsDTOs
{
    public class GetAllCartCheckoutDetailsWithLangDTO
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ColorName { get; set; }
        public decimal DetailPrice { get; set; }
        public int Quantity { get; set; }
        public string SizeNumber { get; set; }
        public string ImagePath { get; set; }
    }
}