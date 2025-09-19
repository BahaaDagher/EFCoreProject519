using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreProject.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        //[Column(TypeName="varchar(50)")]
        [MaxLength(50)]
        [Unicode]
        public string Name { get; set; }  
        public string  Description { get; set; }

        public  List<Product> Products { get; set; }

    }
}
