using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entitys
{
    public class TbFileProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FileProductId { get; set; }

        [ForeignKey("FileId")]
        public int FileId { get; set; }

        [ForeignKey("ProductId")]
        public int ProductId { get; set; }

        public virtual TbFile TbFile { get; set; }
        public virtual TbProduct TbProduct { get; set; }
    }
}
