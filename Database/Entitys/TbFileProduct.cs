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

        public int FileId { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("FileId")]
        public virtual TbFile TbFile { get; set; }

        [ForeignKey("ProductId")]
        public virtual TbProduct TbProduct { get; set; }
    }
}
