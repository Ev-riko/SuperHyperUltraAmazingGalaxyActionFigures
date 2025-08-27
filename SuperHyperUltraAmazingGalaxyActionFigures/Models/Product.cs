using Microsoft.Extensions.Hosting;
using System;

namespace SuperHyperUltraAmazingGalaxyActionFigures.Models
{
    public class Product
    {
        public Guid Id { get; }
        public string Name { get; }
        public decimal Сost { get; }
        public string Description { get; }
        public string ImagePath { get; }

        public Product(string name, decimal сost, string description, string imagePath)
        {
            Id = Guid.NewGuid();
            Name = name;
            Сost = сost;
            Description = description;
            ImagePath = imagePath;
        }
    }
}
