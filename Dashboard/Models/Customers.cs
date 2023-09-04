﻿using System.ComponentModel.DataAnnotations;

namespace Dashboard.Models
{
  
        public class Customers
        {
            [Key]
            public int Id { get; set; }

            public string? Name { get; set; }

            public string? EmailAddress { get; set; }

            public string? PhoneNumber { get; set; }

            public string? Adress { get; set; }

            public string? City { get; set; }

            public string? Region { get; set; }

        }
    }

