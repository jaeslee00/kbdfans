using System.ComponentModel.DataAnnotations;

namespace Kbdfans.Dtos
{
    public class KeyboardAddDto
    {
        // key is genetrated by the database
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Manufacturer { get; set; }    
        [Required]
        public int Price { get; set; }

        //removed price from the model
    }
}