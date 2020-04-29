using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength(30, ErrorMessage = "Maximum 30 charcters")]
        public string Name { get; set; }
        public int Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime Order { get; set; }

        [Required]
        public string Categor { get; set; }
        
        public string Shelf { get; set; }
        [Range(0,10000)]
        public int Count { get; set; }
        public string Descrip { get; set; }
    }                        
}
