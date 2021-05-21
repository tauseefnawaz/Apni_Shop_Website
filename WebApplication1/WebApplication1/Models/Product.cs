using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Product
    {
        [Key]
        public int productId { get; set; }
        [Required]
        public string condition { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = ("Price Must be Positive Value"))]
        public int price { get; set; }
        
        public string ImageName { get; set; }
        
        [NotMapped]
        [DisplayName("Upload Image")]
        public IFormFile ImageFile { get; set; }

        [ForeignKey("User")]
        public int? userId { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual User user { get; set; }
    }
}
