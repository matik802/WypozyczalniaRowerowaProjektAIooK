using System.ComponentModel.DataAnnotations;
using APIWypozyczalniaRowerowaProjektAIooK.Models;

namespace WypozyczalniaRowerowaProjektAIookAPI.Models
{
    public class Bike
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public double Price { get; set; }
        public List<Borrow> Borrows { get; } = new();
    }
}
