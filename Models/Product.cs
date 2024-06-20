using System.ComponentModel.DataAnnotations;

namespace Tray.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Category{ get; set; }
        
        public string? Colour { get; set; }
        public decimal Price { get; set; }
        public string? Size { get; set; }
        public string? Shape { get; set; }
        public string? Rating { get; set; }

    }
}
