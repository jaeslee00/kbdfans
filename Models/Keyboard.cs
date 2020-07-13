using System.ComponentModel.DataAnnotations;

namespace Kbdfans.Models
{
    public class Keyboard
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        [Required]
        public int Price { get; set; }
    }
}