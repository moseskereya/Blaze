using System.ComponentModel.DataAnnotations.Schema;

namespace Blaze.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public decimal Price { get; set; }
        public string? ThumbNail { get; set; }
        public string? Imgurl { get; set; }

        [NotMapped]
        public string? Ratings { get; set; }
        public int? CategoryID { get; set; }
        public Category? Category { get; set; }
    }
}
