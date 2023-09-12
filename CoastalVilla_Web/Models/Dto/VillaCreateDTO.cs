using System.ComponentModel.DataAnnotations;

namespace CoastalVilla_Web.Models.Dto
{
    public class VillaCreateDTO
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public double Rate { get; set; }
        [Required]
        public int Occupancy { get; set; }
        public int? Sqft { get; set; }
        public string? ImageUrl { get; set; }
        [Required]
        public string Amenity { get; set; }
    }
}
