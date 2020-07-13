namespace Kbdfans.Dtos
{
    public class KeyboardGetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Manufacturer { get; set; }

        //removed price from the model
    }
}