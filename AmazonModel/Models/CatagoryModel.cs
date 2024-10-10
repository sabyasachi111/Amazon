using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonModel.Models
{
    public class CatagoryModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int CatID { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Description { get; set; }

        ICollection<StoreProductsModel> products { get; set; }  


    }
}
