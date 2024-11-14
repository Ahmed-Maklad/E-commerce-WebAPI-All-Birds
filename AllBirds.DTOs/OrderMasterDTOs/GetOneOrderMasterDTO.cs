﻿using AllBirds.DTOs.OrderDetailsDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBirds.DTOs.OrderMasterDTOs
{
    public record GetOneOrderMasterDTO
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }

        public int ClientId { get; set; }// name
        public string? ClientName { get; set; }    
        public decimal Total { get; set; }
        public int OrderStateId { get; set; }// order state name 
        public string? OrderStateName { get; set; }

        public string? Notes { get; set; }
        public  int? CouponId { get; set; }  
        public  string? DiscountAmount { get; set; }  
        public  string? DiscountPerctnage { get; set; }  //coupon quantity

        public List<GetAllOrderDetailsDTO> OrdersDetails { get; set; }

    }
}