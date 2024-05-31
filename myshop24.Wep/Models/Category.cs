using System.ComponentModel.DataAnnotations;
namespace myshop24.Wep.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;

    }
}
