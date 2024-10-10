using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonModel.Models
{
    public class CartModel
    {
        [Key]
        [Required]  
        public Guid cartID { get; set; }

        public int ProductID { get; set; }

    }
}
