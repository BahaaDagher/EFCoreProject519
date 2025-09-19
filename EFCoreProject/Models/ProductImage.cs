using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreProject.Models
{
    [PrimaryKey(nameof(ImageUrl) , nameof(ProductId))]
    [Table(nameof(ProductImage) , Schema ="asdas")]
    public class ProductImage
    {
        [Required]
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
