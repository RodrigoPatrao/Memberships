using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;
using System.ComponentModel;

namespace Memberships.Entities
{
    [Table("Item")]
    public class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(255)]
        [Required]
        public string Title { get; set; }
        [MaxLength(2048)]
        public string Description { get; set; }
        [MaxLength(1024)]
        public string Url { get; set; }
        [MaxLength(1024)]
        public string ImageUrl { get; set; }
        [AllowHtml]
        public string HTML { get; set; }
        [NotMapped]
        public string HTMLShort { get; set; }
        public int ItemTypeId { get; set; }
        public int PartId { get; set; }
        public int SectionId { get; set; }
        [DisplayName("Item Types")]
        public virtual ICollection<ItemType> ItemTypes { get; set; }
        public virtual ICollection<Part> Parts { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
        [DisplayName("is free")]
        public bool IsFree { get; set; }
    }
}