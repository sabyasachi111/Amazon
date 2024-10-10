using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonModel.Models
{
    public class StoreProductsModel
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }

        public string PartNumber { get; set; }

        [Required]
        public string? ProductName { get; set; }


        public double Price { get; set; }

        public int Stock { get; set; }

        public string? Manufacturer{ get; set; }

        public double Height { get; set; }

        public double Width { get; set; }

        public  CatagoryModel? Catagory { get; set; }

        public string url { get; set; }
    }
}
