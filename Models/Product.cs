using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApplication17.Models
{
    public class Product
    {
     
        [MaxLength(30)]
        public string Id { get; set; }
        [MaxLength(100)]
        public string Maker { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }
        [MaxLength(1000)]
        [Required]
        public string Url { get; set; }
        [MaxLength(100)]
        [Required]
        public string Title { get; set; }
        [MaxLength(100)]
        [Required]
        public string Description { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);


    }
}
