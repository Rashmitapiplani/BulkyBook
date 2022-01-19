using System;
using System.ComponentModel.DataAnnotations;

namespace BookBulky.Models
{
    public class Category
    {
        public Category()
        {
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int DisplayOrder { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}

