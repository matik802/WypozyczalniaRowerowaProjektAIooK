using System.ComponentModel.DataAnnotations;
using WypozyczalniaRowerowaProjektAIookAPI.Models;

namespace APIWypozyczalniaRowerowaProjektAIooK.Models
{
    public class Borrow
    {
        [Key]
        public int Id { get; set; }
        public int IdBike { get; set; }
        [Required]
        public DateTime DateBorrow { get; set; }
        [Required]
        public int HoursCount { get; set; }
        public Bike Bike { get; set; }
    }
}
