using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Commy.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Category(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}

