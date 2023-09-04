﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Dashboard.Models
{
    public class ProductsDetails
    {
        [Key]
        public int Id { get; set; }

        public int ProductId { get; set; }

        public string? ProductName { get; set; }

        public string? Description { get; set; }

        public double Price { get; set; }

        public string? Model { get; set; }

        public int Qty { get; set; }

        public string? Color { get; set; }

        public string? Image { get; set; }

        public string? Display { get; set; }

    }
}
