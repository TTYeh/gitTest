using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispan_midProject_WinForm47.VM_Models
{
    public class ProductCreateVM
    {
        public int ProductID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(25)]
        public string ProductNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal ListPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal StandardCost { get; set; }

        public DateTime SellStartDate { get; set; }

        public DateTime? SellEndDate { get; set; }

        //public int? ProductCategoryID { get; set; }

        //public int? ProductModelID { get; set; }

        //public Guid rowguid { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
