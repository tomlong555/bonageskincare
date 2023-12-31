﻿using Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entitys
{
    public class TbProduct : EntityTracker
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Unit { get; set; }
        public string Size { get; set; }
        public string ContentHeader { get; set; }
        public string ContentBody { get; set; }
        public bool IsPromote { get; set; }
        public bool IsVegan { get; set; }

        public int ProductGroupId { get; set; }

        [ForeignKey("ProductGroupId")]
        public virtual TbProductGroup TbProductGroup { get; set; }
        public virtual ICollection<TbFileProduct> TbFileProducts { get; set; }

    }
}
