﻿namespace WebApplication2.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Initialize to avoid null reference
        public string Recipient { get; set; } = string.Empty; // Initialize
        public string Supplier { get; set; } = string.Empty; // Initialize
        public decimal Price { get; set; }
        public string ItemType { get; set; } = string.Empty; // Now just a string
    }
}
