using Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entitys
{
    public class TbProductGroup : EntityTracker
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductGroupId { get; set; }
        public string ProductGroupName { get; set; }
        public string ProductGroupDescription { get; set; }
        public virtual ICollection<TbProduct> TbProducts { get; set; }
    }
}
