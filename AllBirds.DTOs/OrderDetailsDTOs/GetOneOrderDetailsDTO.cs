﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBirds.DTOs.OrderDetailsDTOs
{
    public class GetOneOrderDetailsDTO
    {
        public int Id { get; set; }

        public int OrderMasterNo { get; set; }

        public ProductColorSizeImageDTO ProductColorSizeImage { get; set; }

        public int Quantity { get; set; }
        public decimal DetailPrice { get; set; }

        public string? Notes { get; set; }
    }
}
