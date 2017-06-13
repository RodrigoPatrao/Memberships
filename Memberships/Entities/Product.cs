using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Memberships.Entities
{
    [Table("Product")]
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(255)]
        [Required]
        public string Title { get; set; }
        [MaxLength(1024)]
        public string Description { get; set; }
        public int ProductTypeId { get; set; }
        public int ProductLinkTextId { get; set; }
        [MaxLength(1024)]
        public string ImageUrl { get; set; }
    }
}