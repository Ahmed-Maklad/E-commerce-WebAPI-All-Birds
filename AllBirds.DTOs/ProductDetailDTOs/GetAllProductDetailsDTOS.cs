﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBirds.DTOs.ProductDetailDTOs
{
    public class GetAllProductDetailsDTOS
    {
        public int? Id { get; set; }

        public string? TitleAr { get; set; }

        public string? TitleEn { get; set; }

        public string? DescriptionAr { get; set; }

        public string? DescriptionEn { get; set; }

        public string? ImagePath { get; set; }
        public string? ProductNo { get; set; }
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }
    }
}
